using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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