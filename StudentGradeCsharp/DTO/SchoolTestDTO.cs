namespace StudentGradeCsharp.DTO;

public class SchoolTestDTO
{
    public string Title { get; set; }
    public float MaxWeight{ get; set; }
    
    public SchoolTestDTO(){}

    public SchoolTestDTO(string title, float maxWeight)
    {
        Title = title;
        MaxWeight = maxWeight;
    }
}