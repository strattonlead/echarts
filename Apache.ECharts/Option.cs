using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public class Option
    {
        [JsonProperty(PropertyName = "title")]
        public Title Title { get; set; }

        [JsonProperty(PropertyName = "legend")]
        public Legend Legend { get; set; }

        [JsonProperty(PropertyName = "grid")]
        public Grid Grid { get; set; }

        [JsonProperty(PropertyName = "xAxis")]
        public Axis XAxis { get; set; }

        [JsonProperty(PropertyName = "yAxis")]
        public Axis YAxis { get; set; }

        [JsonProperty(PropertyName = "series")]
        public Series[] Series { get; set; }
    }
}
