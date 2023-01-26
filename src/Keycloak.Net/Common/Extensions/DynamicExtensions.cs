namespace Keycloak.Net.Common.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class DynamicExtensions
    {
        public static IDictionary<string, object> DynamicToDictionary(dynamic obj)
        {
            return new Dictionary<string, object>(obj);
        }

        private static string GetFirstPropertyName(IDictionary<string, object> map)
        {
            return map.Keys.FirstOrDefault();
        }

        public static object GetFirstPropertyValue(dynamic obj)
        {
            var map = DynamicToDictionary(obj);
            return map[GetFirstPropertyName(map)];
        }
    }
}
