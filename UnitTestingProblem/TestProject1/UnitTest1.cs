using Xunit;
using UnitTestingProblem;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void DivisibleBy3()
        {
            DivisibleCheck divisibleCheck = new DivisibleCheck();
            divisibleCheck.number = 6;

            Assert.Equal("Fizz", divisibleCheck.DivisibleByNumberCheck());
        }
        [Fact]
        public void DivisibleBy5()
        {
            DivisibleCheck divisibleCheck = new DivisibleCheck();
            divisibleCheck.number = 10;

            Assert.Equal("Buzz", divisibleCheck.DivisibleByNumberCheck());

        }

        [Fact]
        public void DivisibleBy3and5()
        {
            DivisibleCheck divisibleCheck = new DivisibleCheck();
            divisibleCheck.number = 30;

            Assert.Equal("FizzBuzz", divisibleCheck.DivisibleByNumberCheck());

        }

        [Fact]
        public void NotDivisibleBy3and5()
        {
            DivisibleCheck divisibleCheck = new DivisibleCheck();
            divisibleCheck.number = 17;

            Assert.Equal(divisibleCheck.number.ToString(), divisibleCheck.DivisibleByNumberCheck());

        }
    }
}
