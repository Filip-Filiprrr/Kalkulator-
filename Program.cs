﻿using app;
namespace app;
internal class Program
{
    private static void Main(string[] args)
    {
        var kalkulator = new Calculator();
        
        string? dzialanie = "2-2";
        
        double a = 0;
        
        if (dzialanie != null)
        {
            a = kalkulator.Execute(dzialanie);
        }
    }
}