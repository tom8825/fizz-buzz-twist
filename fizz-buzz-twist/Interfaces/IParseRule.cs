using System;
namespace fizz_buzz_twist.Interfaces
{
	public interface IParseRule
	{
        int Divisor { get; set; }
        string Parse(int number);
    }
}

