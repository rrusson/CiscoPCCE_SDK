namespace CiscoPCCE.Toolkit.Bean
{
    public class ScanInfo : BaseApiBean
    {
        public long LastScanDateTime { get; set; }

        public ScanState ScanState { get; set; }
    }
}