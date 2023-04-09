namespace app
{
    public class Calculator
    {
        private static readonly string[] znaki = new string[] { "*", "/", "+", "-" };
        private static readonly int[] liczby = new int[10];
        public double Execute(string exp)
        {
            if (exp != null)
            {

                int a = 0, left, right, wynik;

                for (int i = 0; i < exp.Length; i++)
                {
                    liczby[i] = exp[i];

                    if (exp[i].ToString() == znaki[a])
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
                    }else{
                        return 0;
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
            else
            {
                return 0;
            }
        }



    }
}