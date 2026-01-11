using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vxml")]
    public class VXMLServiceConfig : BaseApiBean
    {
        [XmlElement("enableAppDetailsReporting")]
        public bool? EnableAppDetailsReporting { get; set; }

        [XmlElement("enableReporting")]
        public bool? EnableReporting { get; set; }

        [XmlElement("exclusiveFilters")]
        public string? ExclusiveFilters { get; set; }

        [XmlElement("inclusiveFilters")]
        public string? InclusiveFilters { get; set; }
    }
}