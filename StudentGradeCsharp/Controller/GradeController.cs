using Microsoft.AspNetCore.Mvc;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Service;

namespace StudentGradeCsharp.Controller;

[ApiController]
[Route("api/grade")]
public class GradeController
{
    
    private readonly GradeService _gradeService;

    public GradeController(GradeService gradeService)
    {
        _gradeService = gradeService;
    }

    [HttpPost]
    [Route("add")]
    public IActionResult AddGrade(GradeDTO gradeDto)
    {
        try
        {
            _gradeService.AddGrade(gradeDto);
            return new OkObjectResult(gradeDto);
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }

    [HttpGet]
    [Route("viewAllGrades")]
    public IActionResult ViewAllGrades()
    {
        try
        {
            return new OkObjectResult(_gradeService.GetAllStudentsGrades());
        }
        catch (Exception ex)
        {
            return new BadRequestObjectResult(ex.Message);
        }
    }
}