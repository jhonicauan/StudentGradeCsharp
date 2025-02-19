using Microsoft.AspNetCore.Mvc;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Service;

namespace StudentGradeCsharp.Controller;

[ApiController]
[Route("api/schooltests")]
public class SchoolTestController
{
    private readonly SchoolTestService _schoolTestService;

    public SchoolTestController(SchoolTestService schoolTestService)
    {
        _schoolTestService = schoolTestService;
    }
    
    [HttpGet]
    [Route("view")]
    public IActionResult ViewSchoolTests()
    {
        try
        {
            return new OkObjectResult(_schoolTestService.GetSchoolTests());
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddSchoolTest([FromBody] SchoolTestDTO schoolTest)
    {
        try
        {
            _schoolTestService.AddSchoolTest(schoolTest);
            return new OkObjectResult(schoolTest);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}