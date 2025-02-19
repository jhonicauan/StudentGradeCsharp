namespace StudentGradeCsharp.Error;

public class IdDontExistsException:Exception
{
    public IdDontExistsException(string message) : base(message){}
}