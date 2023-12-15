namespace CreateIf.Apache.ECharts
{
    public abstract class BarSeries : Series
    {
        public override string Type => "bar";
        public string Stack { get; set; }
    }

    public class BarSeries<TValue> : BarSeries
    {
        public TValue[] Data { get; set; }
    }
}
