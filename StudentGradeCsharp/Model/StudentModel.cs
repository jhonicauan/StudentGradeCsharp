using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentGradeCsharp.Model;

[Table("Students")]
public class StudentModel
{
    [Key]
    public int IdStudents{get;private set;}
    public string Name{get;set;}
    public string Enrollment{get;private set;}

    public StudentModel(int id, string name, string enrollment)
    {
        IdStudents = id;
        Name = name;
        Enrollment = enrollment;
    }

    public StudentModel(string name, string enrollment)
    {
        Name = name;
        Enrollment = enrollment;
    }
    
    public StudentModel(){}
}