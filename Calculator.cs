namespace app
{
    public class Calculator
    {
        private static readonly char[] znaki = new char[] { '*', '/', '+', '-' };

        public int j;

        public double Execute(string exp)
        {
            double total = 0;

            //tu metoda do nawiasow 

            for (int i = 0; i < znaki.Length; i++)
            {
                (double, int, bool, int, int) wynik = Calculate(exp, i);

                if (wynik.Item3)
                {
                    exp = SubString(exp, wynik.Item1, wynik.Item2, wynik.Item4, wynik.Item5);
                    total = wynik.Item1;
                    i = 0;
                }
            }

            return total;

        }

        private string SubString(string exp, double wynik, int j, int L, int R)
        {
            string sleft = "", sright = "";

            if (j - L > 0)
            {
                sleft = exp.Substring(0, j - L);
            }

            int startIndexRight = j + R + 1;

            if (startIndexRight < exp.Length - 1)
            {
                sright = exp.Substring(startIndexRight, exp.Length - startIndexRight);
            }


            exp = sleft + wynik.ToString() + sright;

            System.Console.WriteLine(exp);

            return exp;

        }

        private (double, int, bool, int, int) Calculate(string exp, int i)
        {

            int L = 0;
            int R = 0;

            for (int j = 0; j < exp.Length; j++)
            {

                if (exp[j] == znaki[i])
                {
            
                    (double, int) left = NumbersToLeft(exp, j - 1);
                    (double, int) right = NumbersToLeft(exp, j + 1);
                    

                    L = left.Item1.ToString().Length;
                    R = right.Item1.ToString().Length;

                    switch (exp[j].ToString())
                    {
                        case "*":

                            return (left.Item1 * right.Item1, j, true, L, R);

                        case "/":

                            return (left.Item1 / right.Item1, j, true, L, R);

                        case "+":

                            return (left.Item1 + right.Item1, j, true, L, R);

                        case "-":

                            return (left.Item1 - right.Item1, j, true, L, R);

                    }
                }
            }

            return (0, j, false, L, R);
        }

        private (double, int) NumbersToLeft(string exp, int startIndex)
        {
            string N = "";

            int i = startIndex;

            for (; i >= 0; i--)
            {
                if (!isMark(exp[i]))
                {
                    N += exp[i];
                }
                else
                {
                    break;
                }
            }
            string N2 = N;
            char[] zmieniony = N2.ToCharArray();
            Array.Reverse(zmieniony);
            string reversedStr = new string(zmieniony);

            return (double.Parse(reversedStr!), i);
        }



        private (double, int) NumbersToRight(string exp, int startIndex)
        {
            string M = "";

            int i = startIndex;

            for (; i < exp.Length; i++)
            {
                if (!isMark(exp[i]))
                {
                    M += exp[i];
                }
                else
                {
                    break;
                }
            }
            string? M2 = M.ToString();

            return (double.Parse(M2!), i);
        }

        private bool isMark(char d)
        {
            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == d)
                {
                    return true;
                }
            }
            return false;
        }
    }


}