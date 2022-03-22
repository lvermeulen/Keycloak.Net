using Keycloak.Net.Common.Converters;
using Newtonsoft.Json;

namespace Keycloak.Net.Models.Root
{
    [JsonConverter(typeof(LocaleConverter))]
    public enum Locale
    {
        En
    }
}