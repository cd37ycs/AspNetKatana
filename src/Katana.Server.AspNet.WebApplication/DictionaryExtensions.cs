using System.Collections.Generic;

namespace Microsoft.AspNet.Owin.WebApplication
{
    static class DictionaryExtensions
    {
        public static T Get<T>(this IDictionary<string, object> dictionary, string key)
        {
            object value;
            return dictionary.TryGetValue(key, out value) ? (T)value : default(T);
        }
    }
}