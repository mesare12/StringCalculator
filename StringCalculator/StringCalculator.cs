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
            char[] Delimiters = GetDelimeters(number);
            if (number.StartsWith("//"))
            {
                number = number.Substring(4);

            }
            
            string[] split = number.Split(Delimiters);
            
            
            int Value = 0;
            for (int j = 0; j < split.Length; j++)
                Value += int.Parse(split[j]);
            if (Value < 0)
            {
                throw new ArgumentException("Number cannot be negative" + " " +Value);
            }
            return Value;

            
        }

        private static char[] GetDelimeters(string text)
        {
            var Delimiters = new List<char> { ',', '\n' };
            if (text.StartsWith("//"))
            {
                string DelimeterDeclared = text.Split('\n').First();
                char Delimeter = DelimeterDeclared.Substring(2, 1).Single();
                Delimiters.Add(Delimeter);
            }

            return Delimiters.ToArray();
        }
    }
}
