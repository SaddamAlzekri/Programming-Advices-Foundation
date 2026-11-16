using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentDataAccessLayer;

namespace StudentBusinessLayer
{
    public class StudentBusiness
    {
        //public StudentDTO studentDTO
        //{
        //    get
        //    { return (new StudentDTO (this.Id, this.Name, this.Age, this.Grade)); }
        //}
        public StudentDTO SDTO
        {
            get { return (new StudentDTO(this.Id, this.Name, this.Age, this.Grade)); }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        private bool AddStudent(StudentDTO studentDTO)
        {
            int newStudentId = StudentData.AddStudent(studentDTO);
            return (newStudentId != -1);
        }

        public List<StudentDTO> GetAllStudents()
        {
            return StudentData.GetAllStudents();
        }
    }
}
