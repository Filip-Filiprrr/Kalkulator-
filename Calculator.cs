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
                (double, int, bool, int, int) wynik = Calculate(exp, i);

                if (wynik.Item3)
                {
                    exp = SubString(exp, wynik.Item1, wynik.Item2, wynik.Item4, wynik.Item5);
                    total += wynik.Item1;
                    i = 0;
                }
            }

            return total;

        }

        private string SubString(string exp, double wynik, int j, int L, int R)
        {
            string sleft = "", sright = "";

            if (j - 1 > 0)
            {
                sleft = exp.Substring(0, j - L);
            }

            if (j + 2 < exp.Length - 1)
            {
                sright = exp.Substring(j + R, exp.Length - j - R);
            }



            if (isLeftMinus(sleft) && isWynikMinus(wynik))
            {
                sleft = sleft.Remove(sleft.Length - 1) + "+";

            }

            if(isLeftPlus(sleft))
            {
                sleft = sleft.Remove(sleft.Length - 1);
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

                if (exp[j] == znaki[i] && j >= 1)
                {
                    (double, int) left = NumbersToLeft(exp, j - 1);
                    (double, int) right = NumbersToRight(exp, j + 1);

                    L = left.Item1.ToString().Length;
                    R = right.Item1.ToString().Length;

                    (int, double, string) minus = NegativeNumberLeft(j, left.Item1, exp);
                    left.Item1 = minus.Item2;

                    if (left.Item1 < 0)
                    {
                        R++;
                    }

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

        public (double, int) NumbersToLeft(string exp, int startIndex)
        {
            string N = "";

            int i = startIndex;

            for (; i >= 0; i--)
            {
                if (!isMarkLeft(exp[i]))
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

        public bool isMarkLeft(char c)
        {
            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        public (double, int) NumbersToRight(string exp, int startIndex)
        {
            string M = "";

            int i = startIndex;

            for (; i < exp.Length; i++)
            {
                if (!isMarkRight(exp[i]))
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

        public bool isMarkRight(char d)
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

        public (int, double, string) NegativeNumberLeft(int znak, double left, string exp)
        {
            if (znak - left.ToString().Length - 1 >= 0)
                if (isMinus(exp[znak - left.ToString().Length - 1]))
                {
                    left = Double.Parse("-" + left.ToString());
                }

            return (znak, left, exp);

        }

        public bool isMinus(char e)
        {

            if (e.ToString() == "-")
            {
                return true;
            }

            return false;
        }

        public bool isLeftMinus(string f)
        {
            if (f == "")
            {
                return false;
            }
            if (f[f.Length - 1].ToString() == "-")
            {
                return true;
            }

            return false;
        }

        public bool isLeftPlus(string f)
        {
            if (f == "")
            {
                return false;
            }
            if (f[f.Length - 1].ToString() == "+")
            {
                return true;
            }

            return false;
        }

        public bool isWynikMinus(double wynik)
        {
            if (wynik < 0)
            {
                return true;
            }

            return false;
        }
    }
}