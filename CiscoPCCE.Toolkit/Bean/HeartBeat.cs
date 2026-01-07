namespace CiscoPCCE.Toolkit.Bean
{
    public class HeartBeat : BaseApiBean
    {
        public int? Interval { get; set; }

        public int? RequestTimeout { get; set; }

        public int? RetryLimit { get; set; }

        public int? RetryTimeout { get; set; }
    }
}