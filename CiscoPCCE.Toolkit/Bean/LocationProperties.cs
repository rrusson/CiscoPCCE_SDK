using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("locationproperties")
    [XmlRoot("locationProperties")]
    public class LocationProperties : BaseApiBean
    {
        [XmlElement("locationRoutingCodeInsertOption")]
        public string? LocationRoutingCodeInsertOption { get; set; }
    }
}