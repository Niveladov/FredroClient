using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.BaseFunctionsLibrary.Collections
{
    public static class SetExtensions
    {
        public static bool TryAddValue<T>(this ISet<T> set, T value)
        {
            var isAdded = false;
            if (!set.Contains(value))
            {
                set.Add(value);
                isAdded = true;
            }
            return isAdded;
        }
    }
}
