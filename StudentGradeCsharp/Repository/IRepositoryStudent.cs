using StudentGradeCsharp.DTO;

namespace StudentGradeCsharp.Repository;

public interface IRepositoryStudent
{
    public void Add(StudentDTO student);
    
    public List<StudentDTO> GetStudents();
}