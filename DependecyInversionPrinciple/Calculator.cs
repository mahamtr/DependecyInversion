using System.Linq;

namespace DependecyInversionPrinciple
{
    public class Calculator
    {
        public IStringConverter _stringConverter { get; }

        public Calculator(IStringConverter stringConverter)
        {
            _stringConverter = stringConverter;
        }

        public int Add(string numbers)
        {
            var numbersArray = _stringConverter.ConvertStringToNumbers(numbers);
           return numbersArray.Sum();
        }
    }
}