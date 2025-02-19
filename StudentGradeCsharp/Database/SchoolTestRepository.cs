using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Model;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Database;

public class SchoolTestRepository:IRepositorySchoolTest
{
    private readonly ConnectionContext _context;

    public SchoolTestRepository(ConnectionContext context)
    {
        _context = context;
    }

    public void AddSchoolTest(SchoolTestDTO schoolTestDto)
    {
        SchoolTestModel schoolTest = new SchoolTestModel(schoolTestDto.Title, schoolTestDto.MaxWeight);
        _context.Add(schoolTest);
        _context.SaveChanges();
    }

    public List<SchoolTestDTO> GetSchoolTests()
    {
        return _context.SchoolTests.Select(s => new SchoolTestDTO(s.Title, s.MaxWeight)).ToList();
    }
}