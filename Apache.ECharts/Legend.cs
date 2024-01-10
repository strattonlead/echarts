using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public class Legend : BaseChartObject
    {
        [JsonProperty(PropertyName = "data")]
        public LegendData[] Data { get; set; }
    }
}