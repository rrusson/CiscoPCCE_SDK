using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("status")
    [XmlRoot("SystemInfo")]
    public class FinesseSystemInfo : BaseApiBean
    {
        [XmlElement("##default")]
        public string? Status { get; set; }
        
    }
}