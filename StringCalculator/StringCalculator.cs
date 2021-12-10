using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal static class Calculator
    {

        public static int Add(string number)
        {
            if (number.Length == 0)
                return 0;
            return Delimeter(number);

        }

        private static int Delimeter(string number)
        {
            string[] Delimiters = GetDelimeters(number);
            if (number.StartsWith("//")) 
                number = number.Substring(Delimiters.Length - 1);
                number = number.Replace("[", "").Replace("]", "");

            string[] split = number.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries);

            int Value = StringToInt(split);

            return Value;
        }

        private static int StringToInt(string[] split)
        {
            int Value = 0;
            for (int j = 0; j < split.Length; j++)
                Value = FilterNegativeNumbersAndHigherThan1000(split, Value, j);
            return Value;
        }

        private static int FilterNegativeNumbersAndHigherThan1000(string[] split, int Value, int j)
        {
            var tempValue = int.Parse(split[j]);
            if (tempValue <= 1000)
            {
                Value += tempValue;
            }
            if (Value < 0)
            {
                throw new ArgumentException("Number cannot be negative" + " " + Value);
            }

            return Value;
        }

        private static string[] GetDelimeters(string text)
        {
            var Delimiters = new List<string> { ",", "\n"};
            if (text.StartsWith("//"))
            {
                DelimiterDeclaration(text, Delimiters);               
            }

            return Delimiters.ToArray();
        }

        private static void DelimiterDeclaration(string text, List<string> Delimiters)
        {
            string DelimeterDeclared = text.Split('\n').First().Substring(2);
            if (DelimeterDeclared.StartsWith("["))
            {
                Delimiters.Add(DelimeterDeclared.Substring(1, DelimeterDeclared.Length - 2));
            }
            else
            {
                Delimiters.Add(DelimeterDeclared);
            }
        }
    }
}


