using Microsoft.AspNetCore.Mvc;
using StudentManager.Domain.Services;
using StudentManager.Models;

namespace StudentManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                return _service.GetAllStudents();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [HttpGet("{id}")]
        public object Get(int id)
        {
            try
            {
                return _service.GetStudent(id);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [HttpPost]
        public object Save(Student student)
        {
            try
            {
                _service.AddStudent(student);

                return Ok();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [HttpDelete]
        public object Delete(int id)
        {
            try
            {
                _service.DeleteStudent(id);

                return Ok();
            }
            catch (Exception e)
            {
                return e;
            }
        }
    }
}
