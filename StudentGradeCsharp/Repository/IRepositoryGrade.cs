using StudentGradeCsharp.DTO;

namespace StudentGradeCsharp.Repository;

public interface IRepositoryGrade
{
    public void AddGrade(GradeDTO gradeDto);
    
    
    public List<StudentsGradesDto> GetAllStudentsGrades();
}