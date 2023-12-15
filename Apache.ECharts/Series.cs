namespace Apache.ECharts
{
    public abstract class Series
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ColorBy { get; set; } = "series";
        public abstract string Type { get; }
    }
}
