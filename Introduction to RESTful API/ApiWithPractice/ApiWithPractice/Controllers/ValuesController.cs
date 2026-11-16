using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithPractice.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Students/")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("MyName", Name = "GetMyName")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<string> GetMyName()
        {
            return Ok("My Name is Saddam Hussein Al-zekri.");
        }

        [HttpGet("All", Name = "GetAllStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public ActionResult<Student> GetAllStudent()
        {
            return Ok(DataSimullation.DataSimullation.StudentList);
        }

        [HttpGet("Pass", Name = "GetPassStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Student> GetPassStudent()
        {
            var PassStudent = DataSimullation.DataSimullation.StudentList.Where(s => s.Grade >= 50).ToList();
            if(PassStudent == null)
            {
                return NotFound("NotFound : invalide student data.");
            }

            return Ok(PassStudent);
        }

        [HttpGet("GetAverage", Name = "GetAverageStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<double> GetAverageStudent()
        {

            if (DataSimullation.DataSimullation.StudentList.Count() == 0)
            {
                return NotFound("NotFound: invalide student data...");
            }
            var StudentAverage = DataSimullation.DataSimullation.StudentList.Average(s => s.Grade);

            return Ok(StudentAverage);
        }

        [HttpGet("{id}", Name = "GetStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<Student> GetStudentById(int id)
        {
            if(id < 1)
            {
                return BadRequest("BadRequest: invalide student data...");
            }
            var Student = DataSimullation.DataSimullation.StudentList.FirstOrDefault(s => s.Id == id);
            if(Student == null)
            {
                return NotFound("NotFound: invalide student data...");
            }
            return Ok(Student);
        }

        [HttpPost("AddStudent", Name = "AddStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult<Student> AddStudent(Student NewStudent)
        {
            if(NewStudent == null)
            {
                return NotFound("NotFound: invalide student data.");
            }

            NewStudent.Id = DataSimullation.DataSimullation.StudentList.Count() >= 1 ? DataSimullation.DataSimullation.StudentList.Max(s => s.Id) + 1 : 1;
            DataSimullation.DataSimullation.StudentList.Add(NewStudent);
            return CreatedAtRoute("GetStudentById", new { id = NewStudent.Id }, NewStudent);
        }

        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<Student> DeleteStudent(int id)
        {
            if(id < 1)
            {
                return BadRequest("BadRequest: invalide student data...");
            }

            var Student = DataSimullation.DataSimullation.StudentList.FirstOrDefault(s => s.Id == id);

            if(Student == null)
            {
                return NotFound("NotFound: invalide student data...");
            }
            DataSimullation.DataSimullation.StudentList.Remove(Student);
            return Ok(Student);
        }

        [HttpPut("{id}", Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<Student> UpdateStudent(int id,Student UpdateStudent)
        {
            if(id < 1)
            {
                return BadRequest("BadRequest : invalide student data...");
            }
            var Student = DataSimullation.DataSimullation.StudentList.FirstOrDefault(s => s.Id == id);
            if(Student == null)
            {
                return NotFound("NotFound : invalide student data...");
            }
            Student.Name = UpdateStudent.Name;
            Student.Age = UpdateStudent.Age;
            Student.Grade = UpdateStudent.Grade;

            return Ok(Student);
        }


    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
}