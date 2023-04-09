namespace app
{
    public class Calculator
    {
        private static readonly string[] znaki = new string[] { "*", "/", "+", "-" };
        private static readonly int[] liczby = new int[10];
        public double Execute(string exp)
        {
            int a = 0, left, right, wynik;

            return 0;

            for (int i = 0; i < exp.Length; i++)
            {
                liczby[i] = exp[i];

                if (exp[i].ToString() == znaki[a] && i > 1)
                {
                    switch (exp[i].ToString())
                    {
                        case "*":
                            left = liczby[i - 1];
                            right = liczby[i + 1];
                            wynik = left * right;
                            System.Console.WriteLine(wynik);
                            break;

                        case "/":
                            left = liczby[i - 1];
                            right = liczby[i + 1];
                            wynik = left / right;
                            System.Console.WriteLine(wynik);
                            break;

                        case "+":
                            left = liczby[i - 1];
                            right = liczby[i + 1];
                            wynik = left + right;
                            System.Console.WriteLine(wynik);
                            break;

                        case "-":
                            left = liczby[i - 1];
                            right = liczby[i + 1];
                            wynik = left - right;
                            System.Console.WriteLine(wynik);
                            break;
                    }
                }

                if (exp.Length - 1 == i)
                {
                    a++;
                    i = 0;

                    if (a == 4)
                    {
                        return 0;
                    }
                }

            }
        }



    }
}