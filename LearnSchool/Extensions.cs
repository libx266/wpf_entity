using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool
{
    public enum RangeMode
    {
        Include,
        Frontier,
        IncludeMin,
        IncludeMax
    }
    public static class Extensions
    {
        public static decimal ToDecimal(this string value, int entry = 0)
        {
            value += "q";
            string numerics = "0123456789-.,";
            var number = new StringBuilder();
            var numbers = new List<decimal>(entry + 1);
            int index = 0;
            foreach(char c in value)
            {
                if (numerics.Contains(c))
                {
                    number.Append(c);
                }
                else if (number.Length > 0)
                {
                    numbers.Add(Decimal.TryParse(number.ToString().Replace(',', '.'), out decimal result) ? result : 0);
                    number.Clear(); index++;
                }
            }
            return index >= entry + 1 ? numbers[entry] : 0;
        }

        public static bool InRange<T>(this T value, T min, T max, RangeMode mode = RangeMode.Include) where T : IComparable
        {
            switch (mode)
            {
                default: return value.CompareTo(min) >= 0 & value.CompareTo(max) <= 0;
                case RangeMode.Frontier: return value.CompareTo(min) > 0 & value.CompareTo(max) < 0;
                case RangeMode.IncludeMin: return value.CompareTo(min) >= 0 & value.CompareTo(max) < 0;
                case RangeMode.IncludeMax: return value.CompareTo(min) > 0 & value.CompareTo(max) <= 0;
            }
        }
        public static string Join<T>(this IEnumerable<T> data, string sep) =>
            String.Join(sep, data);
    }

    
}
