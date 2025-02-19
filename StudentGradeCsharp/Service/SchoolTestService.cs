using StudentGradeCsharp.Database;
using StudentGradeCsharp.DTO;
using StudentGradeCsharp.Error;
using StudentGradeCsharp.Repository;

namespace StudentGradeCsharp.Service;

public class SchoolTestService
{
    private readonly ConnectionContext _context;
    private readonly IRepositorySchoolTest _repositorySchoolTest;

    public SchoolTestService(ConnectionContext context, IRepositorySchoolTest repositorySchoolTest)
    {
        _context = context;
        _repositorySchoolTest = repositorySchoolTest;
    }

    public void AddSchoolTest(SchoolTestDTO schoolTestDto)
    {
        float Weight = schoolTestDto.MaxWeight;
        if (Weight <= 0 || Weight > 10)
        {
            throw new InvalidLimitException("notas devem estar entre 0 e 10");
        }
        _repositorySchoolTest.AddSchoolTest(schoolTestDto);
    }

    public List<SchoolTestDTO> GetSchoolTests()
    {
        return _repositorySchoolTest.GetSchoolTests();
    }
}