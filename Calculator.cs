namespace app
{
    public class Calculator
    {
        private static readonly char[] znaki = new char[] { '*', '/', '+', '-' };

        public int j;

        public double Execute(string exp)
        {
            double total = 0;
            for (int i = 0; i < znaki.Length; i++)
            {
                (double, int, bool) wynik = Calculate(exp, i);
                
                if (wynik.Item3)
                {
                    exp = SubString(exp, wynik.Item1, wynik.Item2);
                    total += wynik.Item1;
                    i=0;
                }
            }

            return total;

        }

        private string SubString(string exp, double wynik, int j)
        {
            string sleft = "", sright = "";

            if (j - 1 > 0)
            {
                sleft = exp.Substring(0, j - 1);
            }

            if (j + 2 < exp.Length - 1)
            {
                sright = exp.Substring(j + 2, exp.Length - j - 2);
            }

            exp = sleft + wynik.ToString() + sright;

            System.Console.WriteLine(exp);

            return exp;

        }

        private (double, int, bool) Calculate(string exp, int i)
        {

            double left, right;

            for (int j = 0; j < exp.Length; j++)
            {

                if (exp[j] == znaki[i])
                {
                    left = Double.Parse(exp[j - 1].ToString());
                    right = Double.Parse(exp[j + 1].ToString());

                    switch (exp[j].ToString())
                    {
                        case "*":

                            return (left * right, j, true);

                        case "/":

                            return (left / right, j, true);

                        case "+":

                            return (left + right, j, true);

                        case "-":

                            return (left - right, j, true);


                    }
                }
            }
            
            return (0, j, false);
        }
    }
}