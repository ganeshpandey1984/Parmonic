using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingProblem
{
    public class DivisibleCheck
    {
        public int number { get; set; }

        public string DivisibleByNumberCheck()
        {
            string output = string.Empty;
            if (this.number % 3 == 0 && this.number % 5 == 0)
            {
                output = "FizzBuzz";
            }
            else
            {
                if (this.number % 3 == 0)
                {
                    output = "Fizz";
                }
                if (this.number % 5 == 0)
                {
                    output = "Buzz";
                }

            }

            if (this.number % 3 != 0 && this.number % 5 != 0)
            {
                output = this.number.ToString();
            }
            return output;
        }
    }
}
