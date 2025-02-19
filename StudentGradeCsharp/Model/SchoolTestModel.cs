using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGradeCsharp.Model;

[Table("SchoolTest")]
public class SchoolTestModel
{
    [Key]
    public int IdSchoolTest { get; private set;}
    public string Title { get; set;}
    public float MaxWeight { get; set;}

    public SchoolTestModel(int idSchoolTest, string title, float maxWeight)
    {
        IdSchoolTest = idSchoolTest;
        Title = title;
        MaxWeight = maxWeight;
    }
    
    public SchoolTestModel(){}

    public SchoolTestModel(string title, float maxWeight)
    {
        Title = title;
        MaxWeight = maxWeight;
    }
}