namespace CiscoPCCE.Toolkit.Bean
{
    public class Timeout : BaseApiBean
    {
        public int? Abandon { get; set; }

        public int? Late { get; set; }

        public int? Request { get; set; }
    }
}