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
                return CommaSplit(number);
            return int.Parse(number);
           
        }
        
        private static int CommaSplit(string text)
        { 
            var Delimeter = new[] { ',', '\n' };
            string[] split = text.Split(Delimeter);
            
            int Value = 0;
            for (int j = 0; j < split.Length; j++)
                Value = Value + int.Parse(split[j]);
                
            return Value;
        }

       

        
         
        





    }
}
