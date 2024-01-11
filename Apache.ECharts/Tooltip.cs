using Newtonsoft.Json;

namespace Apache.ECharts
{
    public class Tooltip
    {
        [JsonProperty(PropertyName = "trigger")]
        public string Trigger { get; set; }
    }
}
