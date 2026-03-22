namespace Riok.Mapperly.IntegrationTests.Models
{
    public struct StringWrapper
    {
        public StringWrapper(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }

    public class StringWrapperObject
    {
        public StringWrapper Name { get; set; }
    }

    public class PlainStringObject
    {
        public string Name { get; set; } = string.Empty;
    }
}
