using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("speechConfig")]
    public class CVAConfigInfo : BaseApiBean
    {
        [XmlElement("version")]
        public string? Version { get; set; }
    }
}