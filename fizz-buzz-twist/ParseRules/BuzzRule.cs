using System;
using fizz_buzz_twist.Interfaces;

namespace fizz_buzz_twist
{
	public class BuzzRule : IParseRule
    {
        public int Divisor { get; set; } = 5;

		public BuzzRule()
		{

		}


        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
