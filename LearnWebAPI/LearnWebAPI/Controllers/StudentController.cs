using LearnWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name = "GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetStudentName()
        {
            return Ok(CollegeRepository.Students);
        }

        [HttpGet("{id:int}", Name = "GetStudentById")]
        public ActionResult<Student> GetStudentById(int id)
        {
            if (id <= 0) return BadRequest();
            var student = CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
            if (student == null) return NotFound($"The student with ID:{id} not found.");

            return Ok(student);
        }
        [HttpGet("{name:alpha}", Name ="GetStudentByName")]
        public ActionResult<Student> GetStudentByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest();
            var student = CollegeRepository.Students.Where(x => x.StudentName == name).FirstOrDefault();
            if (student == null) return NotFound($"The student with NAME:{name} not found.");

            return Ok(student);
        }
        [HttpDelete("{id}", Name ="DeleteStudentById")]
        public ActionResult<bool> DeleteStudent(int id)
        {
            if (id <= 0) return BadRequest();
            var student = CollegeRepository.Students.Where(x => x.Id == id).FirstOrDefault();
            if (student == null) return NotFound($"The student with ID:{id} does not exist.");

            CollegeRepository.Students.Remove(student);
            return Ok(true);
        }
    }
}
