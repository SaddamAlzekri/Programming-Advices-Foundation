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


namespace AtudentApiClient
{
    public partial class Form1 : Form
    {

        static readonly HttpClient httpClient = new HttpClient();

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Grade { get; set; }
            public string ImagePath { get; set; }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllStudents();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetAllStudents();
            await GetAverageStudent();
            rdbAllStudent.Checked = true;
        }

        private async void rdbPassStudent_CheckedChanged(object sender, EventArgs e)
        {
            await GetPassStudents();
        }

        private async Task GetAllStudents()
        {
            try
            {

                var students = await httpClient.GetFromJsonAsync<List<Student>>("https://localhost:7205/api/Students/GetAllStudents");
                dgvStudents.DataSource = students;
                lblRecordsCount.Text = students.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب البيانات {ex.Message} ", "خطأ في الإتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async Task GetPassStudents()
        {
            try
            {

                var students = await httpClient.GetFromJsonAsync<List<Student>>("https://localhost:7205/api/Students/GetPassStudents");
                dgvStudents.DataSource = students;
                lblRecordsCount.Text = students.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب البيانات {ex.Message} ", "خطأ في الإتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async Task GetAverageStudent()
        {
            try
            {
                decimal AverageStudents = await httpClient.GetFromJsonAsync<decimal>("https://localhost:7205/api/Students/GetAverageStudent");
                lblAverageOfStudents.Text = AverageStudents.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء جلب البيانات {ex.Message} ", "خطأ في الإتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async Task DeleteStudent(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"https://localhost:7205/api/Students/DeleteStudent-{id}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Student with ID {id} has been deleted.");
                    MessageBox.Show("Done Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("BadRequest: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("NotFound: invalide delete data...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Person [" + dgvStudents.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                await DeleteStudent((int)dgvStudents.CurrentRow.Cells[0].Value);
                MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(rdbAllStudent.Checked)
                    await GetAllStudents();
                else
                    await GetPassStudents();
            }
            else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void lblSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                int Number = 0;
                if(int.TryParse(txtSearch.Text, out Number))
                {
                    id = Number;
                }else
                {
                    MessageBox.Show("The converting is fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                var response = await httpClient.GetAsync($"https://localhost:7205/api/Students/{id}");

                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    if (student != null)
                    {
                        lblId.Text = student.Id.ToString(); 
                        lblName.Text = student.Name;
                        lblAge.Text = student.Age.ToString();
                        lblGrade.Text = student.Grade.ToString();
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

        private async void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAddStudent frm = new UpdateAddStudent(UpdateAddStudent.enMode.AddNew, (int)dgvStudents.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            await GetAllStudents();
        }

        private async void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateAddStudent frm = new UpdateAddStudent(UpdateAddStudent.enMode.Update, (int)dgvStudents.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            await GetAllStudents();
        }

        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            UpdateAddStudent frm = new UpdateAddStudent(UpdateAddStudent.enMode.AddNew, (int)dgvStudents.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            await GetAllStudents();
        }
    }

}
