using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("status")]
    public class InventoryStatus : BaseApiBean
    {
        [XmlArray("alerts")]
        [XmlArrayItem("alert")]
        public List<Alert>? Alerts { get; set; }

        [XmlElement("scanInfo")]
        public required ScanInfo ScanInfo { get; set; }
    }
}