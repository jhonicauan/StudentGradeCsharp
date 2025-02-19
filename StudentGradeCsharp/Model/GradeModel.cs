using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGradeCsharp.Model;

[Table("Grade")]
public class GradeModel
{
    [Key]
    public int IdStudents { get; private set; }
    
    [Key]
    public int IdSchoolTest { get; private set; }
    
    public float Weight { get; set; }
    
    public StudentModel Student { get; set; }
    public SchoolTestModel SchoolTest { get; set; }
    
    public GradeModel(){}

    public GradeModel(int idStudent, int idSchoolTest, float weight, StudentModel student, SchoolTestModel schoolTest)
    {
        IdStudents = idStudent;
        IdSchoolTest = idSchoolTest;
        Weight = weight;
        Student = student;
        SchoolTest = schoolTest;
    }

    public GradeModel(int idStudent, int idSchoolTest, float weight)
    {
        IdStudents = idStudent;
        IdSchoolTest = idSchoolTest;
        Weight = weight;
    }
}