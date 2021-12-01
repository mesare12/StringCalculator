using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    internal class Calculator
    {
        public static int Add(string text)
        {
            if (text.Length == 0)
                return 0;
            if (text.Contains(","))
            {
                int Value = CommaSplit(text);
                return Value;
            }

            return int.Parse(text);
           
        }

        private static int CommaSplit(string text)
        {
            string[] split = text.Split(',');
            int Value = 0;
            for (int j = 0; j < split.Length; j++)
                Value = Value + int.Parse(split[j]);
            return Value;
        }







    }
}
