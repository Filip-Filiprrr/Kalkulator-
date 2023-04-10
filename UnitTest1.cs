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
        var kalkulator = new Calculator();

        var wynik = kalkulator.Execute("2*2");

        Assert.AreEqual(4,wynik);
    }

    [Test]
    public void Test2()
    {
        var kalkulator = new Calculator();

        var wynik = kalkulator.Execute("2/2");

        Assert.AreEqual(1,wynik,"2/2!=1");
    }

    [Test]
    public void Test3()
    {
        var kalkulator = new Calculator();

        var wynik = kalkulator.Execute("2+2");

        Assert.AreEqual(4,wynik);
    }

    [Test]
    public void Test4()
    {
        var kalkulator = new Calculator();

        var wynik = kalkulator.Execute("2-2");

        Assert.AreEqual(0,wynik);
    }
    
    // [Test]
    // public void Test5()
    // {
    //     var kalkulator = new Calculator();

    //     var wynik = kalkulator.Execute("2*2+4/2-1");

    //     Assert.AreEqual(5,wynik);
    // }
}