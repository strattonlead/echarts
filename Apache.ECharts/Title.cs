using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public class Title : BaseChartObject
    {
        [JsonProperty(PropertyName = "show")]
        public bool Show { get; set; } = true;

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
