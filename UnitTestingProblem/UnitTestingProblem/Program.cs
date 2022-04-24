using System;

namespace UnitTestingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            DivisibleCheck divisibleCheck = new DivisibleCheck();
            divisibleCheck.number = Convert.ToInt32(Console.ReadLine());
           string output= divisibleCheck.DivisibleByNumberCheck();
            Console.WriteLine(output);

            Console.ReadLine();
        }
    }
}
