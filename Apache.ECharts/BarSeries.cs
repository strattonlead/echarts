using Newtonsoft.Json;

namespace CreateIf.Apache.ECharts
{
    public abstract class BarSeries : Series
    {
        [JsonProperty(PropertyName = "type")]
        public override string Type => "bar";

        [JsonProperty(PropertyName = "stack")]
        public string Stack { get; set; }
    }

    public class BarSeries<TValue> : BarSeries
    {
        [JsonProperty(PropertyName = "data")]
        public TValue[] Data { get; set; }
    }
}
