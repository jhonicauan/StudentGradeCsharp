using Microsoft.EntityFrameworkCore;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Model;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Database;

public class GradeRepository:IRepositoryGrade
{
    private readonly ConnectionContext _context;

    public GradeRepository(ConnectionContext context)
    {
        _context = context;
    }

    public void AddGrade(GradeDTO gradeDto)
    {
        GradeModel grade = new GradeModel(gradeDto.IdStudent,gradeDto.IdSchoolTest,gradeDto.Weight);
        _context.Add(grade);
        _context.SaveChanges();
    }

    public List<StudentsGradesDto> GetAllStudentsGrades()
    {
        return _context.Grades.Include(g => g.Student).Include(g => g.SchoolTest)
            .Select(g => new StudentsGradesDto(g.Student.Name,g.SchoolTest.Title,g.Weight)).ToList();
    }
}