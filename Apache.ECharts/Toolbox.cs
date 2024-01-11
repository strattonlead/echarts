using Newtonsoft.Json;

namespace Apache.ECharts
{
    public class Toolbox
    {
        [JsonProperty(PropertyName = "feature", NullValueHandling = NullValueHandling.Ignore)]
        public Feature Feature { get; set; }
    }
}
