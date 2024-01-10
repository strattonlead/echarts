using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public class Grid : BaseChartObject
    {
        [JsonProperty(PropertyName = "show")]
        public bool Show { get; set; } = true;
    }
}
