using System.Linq;

namespace DependecyInversionPrinciple
{
    public class StringConverter : IStringConverter
    {
        public int[] ConvertStringToNumbers(string stringsNumbers)
        {
            return stringsNumbers.Split(',').Select(i=> int.Parse(i)).ToArray();
        }
    }
}