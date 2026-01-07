namespace CiscoPCCE.Toolkit.Bean
{
    public class PhoneFields : BaseApiBean
    {
        public int CallResult { get; set; }

        public bool? DstObserved { get; set; }

        public int GmtOffset { get; set; }

        public string? Number { get; set; }
    }
}