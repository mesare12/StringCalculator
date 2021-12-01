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
            return int.Parse(text);
            
            

        }
    }
}
