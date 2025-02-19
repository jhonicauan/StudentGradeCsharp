namespace StudentGradeCsharp.DTO;

public class StudentsGradesDto
{
    public string Name { get; set;}
    public string Title { get; set; }
    public float Weight{get;set;}
    
    public StudentsGradesDto(){}

    public StudentsGradesDto(string name, string title, float weight)
    {
        Name = name;
        Title = title;
        Weight = weight;
    }
}