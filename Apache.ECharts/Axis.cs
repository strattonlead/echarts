namespace Apache.ECharts
{
    public abstract class Axis : BaseChartObject
    {
        public bool Show { get; set; } = true;
    }

    public class Axis<TUnit> : Axis
    {
        public TUnit[] Data { get; set; }
    }
}
