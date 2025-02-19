namespace StudentGradeCsharp.Error;

public class UniqueValueException:Exception
{
    public UniqueValueException(string message):base(message){}
}