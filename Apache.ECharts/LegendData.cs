using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public class LegendData
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }
    }
}
