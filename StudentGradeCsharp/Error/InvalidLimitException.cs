namespace StudentGradeCsharp.Error;

public class InvalidLimitException:Exception
{
    public InvalidLimitException(string message):base(message){}
}