using System;
using fizz_buzz_twist.Interfaces;

namespace fizz_buzz_twist
{
	public class FizzBuzzRule : IParseRule
    {
        public int Divisor { get; set; } = 15;

		public FizzBuzzRule()
		{

		}

        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "FizzBuzz";

            return number.ToString();
        }
    }
}
