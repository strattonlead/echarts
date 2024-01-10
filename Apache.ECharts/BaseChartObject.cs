using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public abstract class BaseChartObject
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}