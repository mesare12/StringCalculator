using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class Calculator
    {

        public static int Add(string number)
        {
            if (number.Length == 0)
                return 0;
            if (number.Contains(','))
                return Delimeter(number);
            if (number.Contains(";"))
                return Delimeter(number);
            return int.Parse(number);
           
        }
        
        private static int Delimeter(string text)
        {

            char [] Delimiters = GetDelimeters(text);
            string[] split = text.Split(Delimiters);
           
            int Value = 0;
            for (int j = 0; j < split.Length; j++)
                Value = Value + int.Parse(split[j]);
            return Value;
        }

        private static char[] GetDelimeters(string text)
        {
            var Delimiters = new List<char> { ',', '\n', ';' };
            if (text.StartsWith("//"))
            {
                string DelimeterDeclared = text.Split('\n').First();
                char Delimeter = DelimeterDeclared.Substring(2,1).Single();
                Delimiters.Add(Delimeter);
            }
            return Delimiters.ToArray();
        }
    }
}
