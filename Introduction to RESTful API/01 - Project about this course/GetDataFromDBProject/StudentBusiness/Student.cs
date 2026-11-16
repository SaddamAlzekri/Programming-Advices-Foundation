using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using StudentDataAccess;
using StudentBusiness;

namespace StudentBusiness
{
    public class Student
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode = enMode.AddNew;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Grade { get; set; }
        public string ImagePath { get; set; }

        public StudentDTO StudentDTO
        { get { return (new StudentDTO(this.Id, this.Name, this.Age, this.Grade, this.ImagePath)); } }

        public Student(StudentDTO studentDTO, enMode UpdateMode = enMode.AddNew)
        {
            Id = studentDTO.Id;
            Name = studentDTO.Name;
            Age = studentDTO.Age;
            Grade = studentDTO.Grade;
            ImagePath = studentDTO.ImagePath;

            Mode = UpdateMode;
        }
        private bool AddStudent()
        {
            this.Id = StudentData.AddStudent(StudentDTO);
            return (this.Id != -1);
        }

        private bool UpdateStudent()
        {
            return StudentData.UpdateStudent(StudentDTO);
        }

        public static List<StudentDTO> GetAllStudent()
        {
            return StudentData.GetAllStudents();
        }
        public static bool DeleteStudent(int id)
        {
            return StudentData.DeleteStudent(id);
        }
        
        public static decimal GetAverageStudent()
        {
            return StudentData.GetAverageStudent();
        }

        public static List<StudentDTO> GetPassStudent()
        {
            return StudentData.GetPassStudents();
        }

        public static Student Find(int id)
        {
            StudentDTO studentDTO = StudentData.GetStudentById(id);

            if (studentDTO != null)
            {
                return new Student(studentDTO, enMode.Update);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(AddStudent())
                    {
                        Mode = enMode.Update;
                        return true;
                    }else
                        return false;
                case enMode.Update:
                    return UpdateStudent();
            }
            return false;
        }
    }
}
