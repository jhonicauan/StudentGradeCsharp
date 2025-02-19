using Microsoft.AspNetCore.Mvc;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Error;
using StudentGradeCsharp.Service;

namespace StudentGradeCsharp.Controller;

[ApiController]
[Route("api/students")]
public class StudentController
{
    private readonly StudentService _service;

    public StudentController(StudentService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("view")]
    public IActionResult GetStudents()
    {
        try
        {
            return new OkObjectResult(_service.GetStudents());
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddStudent(StudentDTO student)
    {
        try
        {
            _service.AddStudent(student);
            return new OkObjectResult(student);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}