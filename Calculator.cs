namespace app
{
    public class Calculator
    {
        private static readonly char[] znaki = new char[] { '*', '/', '+', '-' };


        public double Execute(string exp)
        {
            double total = 0;
            for (int i = 0; i < exp.Length; i++)
            {
                (double, bool) wynik = Calculate(exp, i);
                if (wynik.Item2)
                {
                    exp = SubString(exp, wynik.Item1, i);
                    total += wynik.Item1;
                    i=0;
                }
            }

            return total;

        }

        private string SubString(string exp, double wynik, int i)
        {
            string sleft = "", sright = "";

            if (i - 1 > 0)
            {
                sleft = exp.Substring(0, i - 2);
            }

            if (i + 2 < exp.Length - 1)
            {
                sright = exp.Substring(i + 2, exp.Length - i - 2);
            }

            exp = sleft + wynik.ToString() + sright;

            System.Console.WriteLine(exp);

            return exp;

        }

        private (double, bool) Calculate(string exp, int i)
        {

            double left, right;

            for (int j = 0; j < znaki.Length; j++)
            {

                if (exp[i] == znaki[j])
                {
                    left = Double.Parse(exp[i - 1].ToString());
                    right = Double.Parse(exp[i + 1].ToString());

                    switch (exp[i].ToString())
                    {
                        case "*":

                            return (left * right, true);

                        case "/":

                            return (left / right, true);

                        case "+":

                            return (left + right, true);

                        case "-":

                            return (left - right, true);


                    }
                }
            }

            return (0, false);

        }
    }
}
