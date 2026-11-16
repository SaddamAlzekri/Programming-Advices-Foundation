using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentApi.DataSimulation;
using StudentApi.Model;

namespace StudentApi.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Students/")]
    [ApiController]
    public class StudentApiControllerr : ControllerBase
    {
        [HttpGet ("All", Name ="GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(DataSimulation.DataSimulation.StudentList);
        }

        [HttpGet ("Pass", Name ="GetPassStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerable<Student>> GetPassStudents()
        {
            var PassedStudents = DataSimulation.DataSimulation.StudentList.Where(s => s.Grade > 50);
            if(PassedStudents == null)
            {
                return NotFound($"Not students found");
            }
            return Ok(PassedStudents);
        }

        [HttpGet ("AverageGrade", Name = "GetAverageGradeStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<double> GetAverageGradeStudents()
        {

            if (DataSimulation.DataSimulation.StudentList.Count == 0)
            {
                return NotFound("No students found");
            }

            var AverageGrade = DataSimulation.DataSimulation.StudentList.Average(s => s.Grade);
            return Ok(AverageGrade);
        }

        [HttpGet ("{id}", Name = "GetStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Student> GetStudentById(int id)
        {
            if(id < 1)
            {
                return BadRequest($"Not accept id {id}");
            }

            var StudentById = DataSimulation.DataSimulation.StudentList.FirstOrDefault(s => s.Id == id);

            if(StudentById == null)
            {
                return NotFound("Not student found");
            }

            return Ok(StudentById);
        }

        [HttpPost(Name = "AddStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<Student> AddStudent(Student NewStudent)
        {
            if(NewStudent == null | string.IsNullOrEmpty(NewStudent.Name) | NewStudent.Age < 0 | NewStudent.Grade < 0)
            {
                return BadRequest("Not Student Found");
            }
            NewStudent.Id = DataSimulation.DataSimulation.StudentList.Count() > 0 ? DataSimulation.DataSimulation.StudentList.Max(s => s.Id) + 1 : 1;
            DataSimulation.DataSimulation.StudentList.Add(NewStudent);
            return CreatedAtRoute("GetStudentById", new { id = NewStudent.Id }, NewStudent);
        }

        //here we use HttpDelete method
        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteStudent(int id)
        {
            if (id < 1)
            {
                return BadRequest($"Not accepted ID {id}");
            }

            var student = DataSimulation.DataSimulation.StudentList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            DataSimulation.DataSimulation.StudentList.Remove(student);
            return Ok($"Student with ID {id} has been deleted.");
        }


        //here we use http put method for update
        [HttpPut("{id}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Student> UpdateStudent(int id, Student updatedStudent)
        {
            if (id < 1 || updatedStudent == null || string.IsNullOrEmpty(updatedStudent.Name) || updatedStudent.Age < 0 || updatedStudent.Grade < 0)
            {
                return BadRequest("Invalid student data.");
            }

            var student = DataSimulation.DataSimulation.StudentList.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Grade = updatedStudent.Grade;

            return Ok(student);
        }
    }
}
