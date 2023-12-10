using System;
using System.Collections.Generic;

namespace fizz_buzz_twist
{
	public class FizzBuzz
	{
        private readonly int _rangeMin;
        private readonly int _rangeMax;
        public List<string> output = new List<string>();

        public FizzBuzz(int rangeMin, int rangeMax)
        {
            _rangeMin = rangeMin;
            _rangeMax = rangeMax;
            GenerateOutputForRange();
        }

        public void GenerateOutputForRange()
		{
            for (var i = _rangeMin; i <= _rangeMax; i++)
            {
                output.Add(i.ToString());
            }
        }
	}
}

