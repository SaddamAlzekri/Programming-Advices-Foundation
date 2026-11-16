using AtudentApiClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AtudentApiClient.Form1;

namespace AtudentApiClient
{
    public partial class UpdateAddStudent : Form
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Grade { get; set; }
            public string ImagePath { get; set; }

        }

        public UpdateAddStudent()
        {
            InitializeComponent();
        }
        Student student;
        string SourceImageFile = "";
        Student addedStudent = new Student();
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int Id { set; get; }
        static readonly HttpClient httpClient = new HttpClient();

        public UpdateAddStudent(enMode frmMode, int Id = 0)
        {
            InitializeComponent();
            if (frmMode == enMode.AddNew)
                lbltitle.Text = "Add Student";
            else
                lbltitle.Text = "Update Student";

            this.Id = Id;
            Mode = frmMode;
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                await AddStudent();
            }else
            {

                await UpdateStudent(Id);
            }
        }
        private async Task AddStudent()
        {
            try
            {
                int AgeOfStudent = 0;
                int Number = 0;

                if (int.TryParse(txtAge.Text, out Number))
                {
                    AgeOfStudent = Number;
                }
                else
                {
                    MessageBox.Show("The converting is fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /////////

                int GradeOfStudent = 0;
                int NumberOf2 = 0;

                if (int.TryParse(txtAge.Text, out NumberOf2))
                {
                    GradeOfStudent = NumberOf2;
                }
                else
                {
                    MessageBox.Show("The converting is fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                if (!_HandlePersonImage())
                    return;

                var NewStudent = new Student
                {
                    Id = 5,
                    Name = txtName.Text,
                    Age = AgeOfStudent,
                    Grade = GradeOfStudent,
                    ImagePath = SourceImageFile
                };

                var response = await httpClient.PostAsJsonAsync("https://localhost:7205/api/Students", NewStudent);

                if (response.IsSuccessStatusCode)
                {
                    addedStudent = await response.Content.ReadFromJsonAsync<Student>();
                    lblId.Text = addedStudent.Id.ToString();
                    MessageBox.Show("Done the added :-)", "Add Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("BadRequest: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task UpdateStudent(int id)
        {
            try
            {
                int AgeOfStudent = 0;
                int Number = 0;

                if (int.TryParse(txtAge.Text, out Number))
                {
                    AgeOfStudent = Number;
                }
                else
                {
                    MessageBox.Show("The converting is fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                /////////

                int GradeOfStudent = 0;
                int NumberOf2 = 0;

                if (int.TryParse(txtAge.Text, out NumberOf2))
                {
                    GradeOfStudent = NumberOf2;
                }
                else
                {
                    MessageBox.Show("The converting is fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!_HandlePersonImage())
                    return;

                var UpdateStudent = new Student
                {
                    Id = id,
                    Name = txtName.Text,
                    Age = AgeOfStudent,
                    Grade = GradeOfStudent,
                    ImagePath = SourceImageFile

                };

                var response = await httpClient.PutAsJsonAsync($"https://localhost:7205/api/Students/{id}", UpdateStudent);

                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    MessageBox.Show("Done the Updating :-)", "Add Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("BadRequest: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("BadRequest: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateAddStudent_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.Update)
            {
                try
                {
                    var response = await httpClient.GetAsync($"https://localhost:7205/api/Students/{Id}");

                    if (response.IsSuccessStatusCode)
                    {
                        student = await response.Content.ReadFromJsonAsync<Student>();
                        if (student != null)
                        {
                            lblId.Text = student.Id.ToString();
                            txtName.Text = student.Name;
                            txtAge.Text = student.Age.ToString();
                            txtGrade.Text = student.Grade.ToString();
                            if(File.Exists(student.ImagePath))
                            {
                                pbPersonalImage.Load(student.ImagePath);
                            }
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            MessageBox.Show("NotFound: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llSetImgee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonalImage.Load(selectedFilePath);
                llRemoveImage.Visible = true;
                // ...
               // MessageBox.Show(selectedFilePath, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonalImage.ImageLocation = null;

            llRemoveImage.Visible = false;
        }


        private bool _HandlePersonImage()
        {

            //this procedure will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            //MessageBox.Show(student.ImagePath, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(pbPersonalImage.ImageLocation, "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (student.ImagePath != pbPersonalImage.ImageLocation)
            {
                if (student.ImagePath != "")
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(student.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (pbPersonalImage.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    SourceImageFile = pbPersonalImage.ImageLocation.ToString();

                    if (clsGlobalFun.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonalImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

    }
}

