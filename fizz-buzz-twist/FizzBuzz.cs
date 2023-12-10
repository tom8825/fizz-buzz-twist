using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using fizz_buzz_twist.Interfaces;

namespace fizz_buzz_twist
{
	public class FizzBuzz
	{
        private readonly int _rangeMin;
        private readonly int _rangeMax;
        private List<IParseRule> _parseRules; 
        public List<string> output = new List<string>();

        public FizzBuzz(int rangeMin, int rangeMax)
        {
            _rangeMin = rangeMin;
            _rangeMax = rangeMax;
            GenerateOutputForRange();
        }

        public void GenerateOutputForRange()
		{
            // the previous solution worked for a static set of rules.
            // i have refactored this to increase scalability.
            // GetParseRules will use reflection to collect all classes implementing IParseRule
            // (ordered by divisor desc to favor specificity) and find the first rule that matches
            // the current index.
            // more rules can be added to the ParseRules folder to alter the output without having
            // to modify the code.


            for (var i = _rangeMin; i <= _rangeMax; i++)
            {
                var rules = GetParseRules();
                IParseRule numberParser = rules.FirstOrDefault(p => i % p.Divisor == 0);
                if(numberParser != null)
                {
                    output.Add(numberParser.Parse(i));
                }
                else
                {
                    output.Add(i.ToString());
                }
            }
            output.ForEach(Console.WriteLine);
        }

        public List<IParseRule> GetParseRules()
        {
            //rules are held in memory to reduce unnecessary calls
            if (_parseRules != null)
                return _parseRules;

            var interfaceType = typeof(IParseRule);
            return
                _parseRules
                   = AppDomain.CurrentDomain.GetAssemblies()
                         .SelectMany(x => x.GetTypes())
                         .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                         .Select(x => Activator.CreateInstance(x))
                         .Cast<IParseRule>()
                         .OrderByDescending(p => p.Divisor)
                         .ToList();
        }
    }
}

