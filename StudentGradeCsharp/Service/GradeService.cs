using StudentGradeCsharp.Database;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Error;
using StudentGradeCsharp.Model;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Service;

public class GradeService
{
    private readonly IRepositoryGrade _repositoryGrade;
    private readonly ConnectionContext _connectionContext;
    public GradeService(IRepositoryGrade repositoryGrade, ConnectionContext connectionContext)
    {
        _repositoryGrade = repositoryGrade;
        _connectionContext = connectionContext;
    }

    public void AddGrade(GradeDTO gradeDto)
    {
        if (!checkStudent(gradeDto.IdStudent))
        {
            throw new IdDontExistsException("Estudante não existe!");
        }

        if (!checkSchoolTest(gradeDto.IdSchoolTest))
        {
            throw new IdDontExistsException("Prova não existe!");
        }

        if (checkGrade(gradeDto.IdStudent, gradeDto.IdSchoolTest))
        {
            throw new UniqueValueException("Esta prova já foi feita por este aluno");
        }
        if (gradeDto.Weight < 0)
        {
            throw new InvalidLimitException("Notas devem ser maior ou igual a 0");
        }
        SchoolTestModel schoolTest = _connectionContext.SchoolTests.Where(s => s.IdSchoolTest == gradeDto.IdSchoolTest).First();
        if (schoolTest.MaxWeight < gradeDto.Weight)
        {
            throw new InvalidLimitException("Notas passou do limite estabelecido");
        }
        _repositoryGrade.AddGrade(gradeDto);
    }

    public List<StudentsGradesDto> GetAllStudentsGrades()
    {
      return _repositoryGrade.GetAllStudentsGrades();
    }

    private bool checkStudent(int idStudent)
    {
        return _connectionContext.Students.Count(s => s.IdStudents == idStudent) > 0;
    }

    private bool checkSchoolTest(int idSchoolTest)
    {
        return _connectionContext.SchoolTests.Count(s => s.IdSchoolTest == idSchoolTest) > 0;
    }

    private bool checkGrade(int idStudent, int idSchoolTest)
    {
        return _connectionContext.Grades.Count(g => g.IdSchoolTest == idSchoolTest && g.IdStudents == idStudent) > 0;
    }
}