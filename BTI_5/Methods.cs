using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTI_5
{
    public static class Methods
    {
        public static IEnumerable<int> ToIntList(this string data) => data.Replace(" ", string.Empty).Select(x => (int)char.GetNumericValue(x)).ToList();
        public static string ListToString(this IEnumerable<int> data) => string.Join("", data);
        public static IEnumerable<int> To64BitK(this IEnumerable<int> input) => Enumerable.Repeat(0, Math.Max(0, 64 - input.Count())).Concat(input);
    }
}