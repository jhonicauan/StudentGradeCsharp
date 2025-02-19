using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Model;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Database;

public class StudentRepository:IRepositoryStudent
{
    private readonly ConnectionContext _context;

    public StudentRepository(ConnectionContext context)
    {
        _context = context;
    }

    public void Add(StudentDTO studentDto)
    {
        StudentModel student = new StudentModel(studentDto.Name, studentDto.Enrollment);
            _context.Add(student);
            _context.SaveChanges();
    }

    public List<StudentDTO> GetStudents()
    {
       return  _context.Students.Select(s=>new StudentDTO(s.Name, s.Enrollment)).ToList();
    }
}