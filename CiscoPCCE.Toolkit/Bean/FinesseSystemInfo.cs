using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("SystemInfo")]
    public class FinesseSystemInfo : BaseApiBean
    {
        [XmlElement("##default")]
        public string? Status { get; set; }
    }
}