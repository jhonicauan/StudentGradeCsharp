using StudentGradeCsharp.Database;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Error;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Service;

public class StudentService
{
    private readonly IRepositoryStudent _repositoryStudent;
    private readonly ConnectionContext _context;

    public StudentService(IRepositoryStudent repositoryStudent, ConnectionContext context)
    {
        _repositoryStudent = repositoryStudent;
        _context = context;
    }
    public void AddStudent(StudentDTO student)
    {
        int count = _context.Students.Count(s => s.Enrollment == student.Enrollment);
        if (count == 0)
        {
            _repositoryStudent.Add(student);
        }
        else
        {
            throw new UniqueValueException("Matricula já existe!");
        }
    }

    public List<StudentDTO> GetStudents()
    {
        return _repositoryStudent.GetStudents();
    }
}