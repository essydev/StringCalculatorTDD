using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        private const int defaultValue = 0;
        private const char defaultSeperator = ',';

        private NumbersSanitizer _numbersSanitizer;

        public StringCalculator()
        {
            _numbersSanitizer = new NumbersSanitizer(defaultSeperator);
        }

        public int Add(string numbers)
        {
            numbers = _numbersSanitizer.SanitizeNumbers(numbers);

            if (ShouldReturnDefaultNumber(numbers))
            {
                return defaultValue;
            }

            var splitNumbers = ConvertToNumbersList(numbers);
            splitNumbers = RemoveNegativeNumbers(splitNumbers);

            return SumNumbers(splitNumbers);
        }

        private List<int> RemoveNegativeNumbers(List<int> splitNumbers)
        {
            return splitNumbers.Where(x => x >= 0).ToList();
        }

        private int SumNumbers(List<int> splitNumbers)
        {
            return splitNumbers.Sum();
        }

        private List<int> ConvertToNumbersList(string numbers)
        {
            var splitNumbers = SplitNumbers(numbers);
            return splitNumbers.Select(ConvertSingleNumber).ToList();
        }

        private string[] SplitNumbers(string numbers)
        {
            return numbers.Split(defaultSeperator);
        }

        private int ConvertSingleNumber(string numbers)
        {
            return Int32.Parse(numbers);
        }

        private static bool ShouldReturnDefaultNumber(string numbers)
        {
            return numbers == String.Empty;
        }
    }
}
