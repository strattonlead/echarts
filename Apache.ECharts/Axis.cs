using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public abstract class Axis : BaseChartObject
    {
        [JsonProperty(PropertyName = "show")]
        public bool Show { get; set; } = true;
    }

    public class Axis<TUnit> : Axis
    {
        [JsonProperty(PropertyName = "data")]
        public TUnit[] Data { get; set; }
    }
}
