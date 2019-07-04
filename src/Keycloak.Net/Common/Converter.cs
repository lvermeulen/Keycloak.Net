using System.Collections.Generic;
using System.Linq;

namespace Keycloak.Net.Common
{
    public static class Converter
    {
        private static string GetFirstPropertyName(IDictionary<string, object> map) => map.Keys.FirstOrDefault();

        public static object GetFirstPropertyValue(dynamic obj)
        {
            var map = new Dictionary<string, object>(obj);
            return map[GetFirstPropertyName(map)];
        }
    }
}
