namespace Apache.ECharts
{
    public class Option
    {
        public Title Title { get; set; }
        public Legend Legend { get; set; }
        public Grid Grid { get; set; }
        public Axis XAxis { get; set; }
        public Axis YAxis { get; set; }
        public Series[] Series { get; set; }
    }
}
