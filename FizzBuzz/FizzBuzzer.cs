using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Get(int num)
        {

            if (IsMultipleofThree(num) && (IsMultipleofFive(num)))
            {
                return "FizzBuzz";
            }

            if (IsMultipleofThree(num))
            {
                return "Fizz";
            }

            if(IsMultipleofFive(num))
            {
                return "Buzz";
            }
            
            
            return num.ToString();
        }

        private bool IsMultipleofThree(int number)
        {
            return number % 3 == 0;
        }
        private bool IsMultipleofFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
