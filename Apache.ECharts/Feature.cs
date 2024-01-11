using Newtonsoft.Json;

namespace Apache.ECharts
{
    public class Feature
    {
        [JsonProperty(PropertyName = "saveAsImage", NullValueHandling = NullValueHandling.Ignore)]
        public object SaveAsImage { get; set; }
    }
}
