using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.BaseFunctionsLibrary.Collections
{
    public static class DictionaryExtensions
    {
        public static bool IsEqual<TKey, TValue>(this IDictionary<TKey, TValue> dict1, IDictionary<TKey, TValue> dict2)
        {
            if (null == dict1 || null == dict2) return false;
            else if (dict1 == dict2) return true; /*object.ReferenceEquals(dict1, dict2)*/
            else if (dict1.Count != dict2.Count) return false;

            foreach (var pair in dict1)
            {
                TValue value2;
                if (!dict2.TryGetValue(pair.Key, out value2)) return false;
                else if (!pair.Value.Equals(value2)) return false;
            }

            return true;
        }
    }
}
