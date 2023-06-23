using System.Text.Json.Serialization;

namespace SugarNewsAPI.Constants
{
    public enum Categories
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Business,
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Entertainment,
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Health,
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Science,
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Sports,
        [JsonConverter(typeof(JsonStringEnumConverter))]
        Technology
    }
}

