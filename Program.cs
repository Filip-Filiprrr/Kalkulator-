using app;
namespace app;
internal class Program
{
    private static void Main(string[] args)
    {
        // var calculator = new Calculator();

        // System.Console.WriteLine("Wpisz dzialanie:");
        
        // string? operation = "2+2*3+4/2";
        
        // double a = 0;
        
        // if (operation != null)
        // {
        //     a = calculator.Execute(operation);
        // }

        // System.Console.WriteLine(a);

        string exp = "7+2*4";

        var p = new Parser(exp);
        
        var l = p.ReadAll();

        foreach(var t in l)
        {
            System.Console.WriteLine("{0} - {1}", t.Value(), t.TokenType());
        }

        // var r = new Reader(exp);

        // while(r.MoveNext())
        // {
        //     var t = r.Current;
        //     System.Console.WriteLine("{0} - {1}", t.Value(), t.TokenType());
        // }
    }
}