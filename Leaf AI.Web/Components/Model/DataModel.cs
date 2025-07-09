using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Leaf_AI.Web.Components.Model.Models
{
    public class FeatureOption
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }
    }

    public class Features
    {
        [JsonPropertyName("shape")]
        public string Shape { get; set; }

        [JsonPropertyName("margin")]
        public string Margin { get; set; }

        [JsonPropertyName("venation")]
        public string Venation { get; set; }
    }

    public class ObjectItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("features")]
        public Features Features { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public class DataModel
    {
        [JsonPropertyName("feature_options")]
        public Dictionary<string, List<FeatureOption>> FeatureOptions { get; set; }

        [JsonPropertyName("objects")]
        public List<ObjectItem> Objects { get; set; }
    }
}
