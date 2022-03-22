using System.Collections.Generic;
using System.Linq;

namespace Keycloak.Net.Common.Extensions
{
    public static class DynamicExtensions
    {
        public static IDictionary<string, object> DynamicToDictionary(dynamic obj) => new Dictionary<string, object>(obj);

        private static string GetFirstPropertyName(IDictionary<string, object> map) => map.Keys.FirstOrDefault();

        public static object GetFirstPropertyValue(dynamic obj)
        {
            var map = DynamicToDictionary(obj);
            return map[GetFirstPropertyName(map)];
        }
    }
}
