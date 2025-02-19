using StudentGradeCsharp.DTO;

namespace StudentGradeCsharp.Repository;

public interface IRepositorySchoolTest
{
    public void AddSchoolTest(SchoolTestDTO schoolTestDto);
    
    public List<SchoolTestDTO> GetSchoolTests();
}