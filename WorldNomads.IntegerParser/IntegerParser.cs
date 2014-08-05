using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNomads.Utility
{
    public static class IntegerParser
    {
        public static string GetAllNumbers(int input)
        {
            if (input < 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i <= input; i++)
            {
                AppendString(sb, i.ToString());
            }
            return sb.ToString();
        }

        public static string GetOddNumbers(int input)
        {
            return GetNumbers(input, NumberType.ODD);
        }

        public static string GetEvenNumbers(int input)
        {
            return GetNumbers(input, NumberType.EVEN);
        }

        public static string GetSpecialNumbers(int input)
        {
            if (input < 0)
            {
               return string.Empty;
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                if (IsMultiple(i, 3) && IsMultiple(i, 5))
                {
                    AppendString(sb, "fizz buzz");
                }
                else if (IsMultiple(i, 3))
                {
                    AppendString(sb, "fizz");
                }
                else if (IsMultiple(i, 5))
                {
                    AppendString(sb, "buzz");
                }
                else
                {
                    AppendString(sb, i.ToString());
                }

            }
            return sb.ToString();
        }

        public static string GetFibonacciNumbers(int input)
        {
            int a = 0;
            int b = 1;
            StringBuilder sb = new StringBuilder();

            while (a <= input)
            {
                AppendString(sb, a.ToString());
                int temp = a;
                a = b;
                b = temp + b;
            }
            return sb.ToString();
        }

        #region Helper

        private static string GetNumbers(int input, NumberType numberType)
        {
            if (input < 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= input; i++)
            {
                if ((numberType == NumberType.ODD && IsOdd(i)) ||
                    (numberType == NumberType.EVEN && IsEven(i)))
                {
                    AppendString(sb, i.ToString());
                }
            }

            return sb.ToString();
        }

        private static bool IsOdd(int input)
        {
            return !IsDivisble(input, 2);
        }

        private static bool IsEven(int input)
        {
            return IsDivisble(input, 2);
        }

        private static bool IsDivisble(int input, int divider)
        {
            return (input % divider) == 0;
        }

        private static bool IsMultiple(int input, int divider)
        {
            if (input >= divider)
            {
                return (input % divider) == 0;
            }
            return false;
        }

        private static void AppendString(StringBuilder sb, string s)
        {
            if (sb.Length > 0)
            {
                sb.Append(string.Format(",{0}", s));
            }
            else
            {
                sb.Append(string.Format("{0}", s));
            }
        }

        #endregion
    }
}
