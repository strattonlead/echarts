using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public abstract class Series
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "colorBy")]
        public string ColorBy { get; set; } = "series";

        [JsonProperty(PropertyName = "type")]
        public abstract string Type { get; }
    }
}
