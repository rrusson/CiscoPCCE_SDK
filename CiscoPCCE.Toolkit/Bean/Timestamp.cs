namespace CiscoPCCE.Toolkit.Bean
{
    public class Timestamp : BaseApiBean
    {
        public int Date { get; set; }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        public int Month { get; set; }

        public int Nanos { get; set; }

        public int Seconds { get; set; }

        public long Time { get; set; }

        public int Year { get; set; }
    }
}