using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator
{
    public class NumbersSanitizer
    {
        private readonly char _defaultSeperator;

        public NumbersSanitizer(char defaultSeperator)
        {
            _defaultSeperator = defaultSeperator;
        }

        public string SanitizeNumbers(string numbers)
        {
            if (ContainsSeperatorSpecifier(numbers))
            {
                numbers = ReplaceWithDefaultSeperator(numbers, numbers[2]);
                numbers = RemoveSeperateSpecifier(numbers);
            }

            return ReplaceWithDefaultSeperator(numbers, '\n');
        }

        private string RemoveSeperateSpecifier(string numbers)
        {
            return numbers.Substring(4);
        }

        private string ReplaceWithDefaultSeperator(string numbers, char oldSeperator)
        {
            return numbers.Replace(oldSeperator, _defaultSeperator);
        }

        private bool ContainsSeperatorSpecifier(string numbers)
        {
            return numbers.StartsWith("//");
        }

    }
}

