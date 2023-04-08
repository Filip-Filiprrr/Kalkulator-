using app;
using NUnit.Framework;

namespace tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        double wynik1 = new Calculator().Execute("2+2");

        var kalkulator = new Calculator();
        
        string[] znaki = new string[] {"/", "*", "+", "-" };

        for (int i = 0; i < kalkulator.exp.Length; i++)
        {
            if (kalkulator.exp[] == znaki[])
            {
                
            }
        }
       
        Assert.Equals(4, wynik1);
      
    }
    [Test]
    public void Test2()
    {
        double wynik2 = new Calculator().Execute("2+2*2");
        
        string[] znaki = new string[] {"/", "*", "+", "-" };
        
        Assert.Equals(6, wynik2);
    }
}