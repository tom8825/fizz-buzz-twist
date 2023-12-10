using System;
using fizz_buzz_twist.Interfaces;

namespace fizz_buzz_twist
{
	public class FizzRule : IParseRule
    {
        public int Divisor { get; set; } = 3;

		public FizzRule()
		{

		}

        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "Fizz";

            return number.ToString();
        }
    }
}
