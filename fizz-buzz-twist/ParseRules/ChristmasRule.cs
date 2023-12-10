using System;
using fizz_buzz_twist.Interfaces;

namespace fizz_buzz_twist
{
	public class ChristmasRule : IParseRule
    {
        public int Divisor { get; set; } = 25;

		public ChristmasRule()
		{

		}

        public string Parse(int number)
        {
            if (number % Divisor == 0)
                return "Christmas";

            return number.ToString();
        }
    }
}
