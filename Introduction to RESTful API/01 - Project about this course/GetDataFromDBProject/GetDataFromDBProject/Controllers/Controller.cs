using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentBusiness;
using StudentDataAccess;

namespace GetDataFromDBProject.Controllers
{
    // [Route("api/[controller]")]
    [Route("api/Students")]
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet("GetAllStudents", Name = "GetAllStduents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerator<StudentDTO>> GetAllStudents()
        {
            List<StudentDTO> StudentsList = Student.GetAllStudent();
            if (StudentsList.Count == 0)
            {
                return NotFound("No Students Found!");
            }
            return Ok(StudentsList); 
        }

        [HttpDelete("DeleteStudent-{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult DeleteStudent(int id)
        {
            if(id < 1)
            {
                return BadRequest($"Not accepted ID {id}");
            }

            if(StudentData.DeleteStudent(id))
                return Ok($"Student with ID {id} has been deleted.");
            else
                return NotFound($"Student with ID {id} not found. no rows deleted!"); 
        }

        [HttpGet("GetAverageStudent", Name = "GetAverageStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<decimal> GetAverageStudent()
        {
            decimal AverageStudent = StudentData.GetAverageStudent();
            return Ok(AverageStudent);
        }

        [HttpGet("GetPassStudents", Name = "GetPassStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<IEnumerator<StudentDTO>> GetPassStudents()
        {
            List<StudentDTO> StudentsList = Student.GetPassStudent();
            if (StudentsList.Count == 0)
            {
                return NotFound("No Students Found!");
            }
            return Ok(StudentsList); // Returns the list of students.
        }

        [HttpGet("{id}", Name = "GetStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<StudentDTO> Find(int id)
        {
            StudentBusiness.Student StudentsList = Student.Find(id);
            if (StudentsList == null)
            {
                return NotFound("No Students Found!");
            }
            StudentDTO studentDTO = StudentsList.StudentDTO;

            return Ok(studentDTO); // Returns the list of students.
        }

        [HttpPost(Name = "AddStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<StudentDTO> AddStudent(StudentDTO newStudentDTO)
        {
            if (newStudentDTO == null || string.IsNullOrEmpty(newStudentDTO.Name) || newStudentDTO.Age < 0 || newStudentDTO.Grade < 0)
            {
                return BadRequest("Invalid student data.");
            }

            StudentBusiness.Student student = new StudentBusiness.Student(new StudentDTO(newStudentDTO.Id, newStudentDTO.Name, newStudentDTO.Age,
            newStudentDTO.Grade, newStudentDTO.ImagePath));
            student.Save();

            newStudentDTO.Id = student.Id;

            return CreatedAtRoute("GetStudentById", new { id = newStudentDTO.Id }, newStudentDTO);

        }


        [HttpPut("{id}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<StudentDTO> UpdateStudent(int id, StudentDTO updatedStudent)
        {
            if (id < 1 || updatedStudent == null || string.IsNullOrEmpty(updatedStudent.Name) || updatedStudent.Age < 0 || updatedStudent.Grade < 0)
            {
                return BadRequest("Invalid student data.");
            }


            StudentBusiness.Student student = StudentBusiness.Student.Find(id);


            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Grade = updatedStudent.Grade;
            student.ImagePath = updatedStudent.ImagePath;

            student.Save();

            return Ok(student.StudentDTO);

        }

    }
}
