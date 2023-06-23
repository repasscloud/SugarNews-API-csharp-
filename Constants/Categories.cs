using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace SugarNewsAPI.Constants
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Categories
    {
        Business,
        Entertainment,
        Health,
        Science,
        Sports,
        Technology
    }
}

