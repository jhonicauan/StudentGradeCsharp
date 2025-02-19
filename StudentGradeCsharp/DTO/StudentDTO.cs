namespace StudentGradeCsharp.DTO;

public class StudentDTO
{
    public string Name { get; set; }
    public string Enrollment{get;set;}

    public StudentDTO(string name, string enrollment)
    {
        Name = name;
        Enrollment = enrollment;
    }
    
    public StudentDTO(){}
}