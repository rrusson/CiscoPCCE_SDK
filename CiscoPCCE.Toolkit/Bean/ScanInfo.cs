using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ScanInfo : BaseApiBean
    {
        [XmlElement("lastScanDateTime")]
        public long LastScanDateTime { get; set; }

        [XmlElement("scanState")]
        public ScanState ScanState { get; set; }
    }
}