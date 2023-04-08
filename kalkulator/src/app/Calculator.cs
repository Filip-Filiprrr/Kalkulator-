namespace app;

public class Calculator
{
    private static readonly string[] znaki = new string[] {"/", "*", "+", "-" };

    public string exp;

    public string Exp => exp;
    public double Execute(string exp)
    {
        if (exp.Length == 0)
        {
            return 0;
        }

        return 0;
    }

    private void Count(char[] exp, int startIndex)
    {
        
    }
}

[Serializable]
public class InvalidGradeException : Exception
{
    public InvalidGradeException() : base() { }
    public InvalidGradeException(string message) : base(message) { }
    public InvalidGradeException(string message, Exception inner) : base(message, inner) { }
}