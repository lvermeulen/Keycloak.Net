namespace Keycloak.Net.Models.Root
{
    public struct DefaultValue
    {
        private bool _isBool;
        private bool? _bool;
        private string _string;

        public static implicit operator DefaultValue(bool value) => new DefaultValue { _isBool = true, _bool = value };
        public static implicit operator DefaultValue(string value) => new DefaultValue { _isBool = false, _string = value };
    }
}