using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vxml")]
    public class VXMLServiceConfig : BaseApiBean
    {
        public bool? EnableAppDetailsReporting { get; set; }

        public bool? EnableReporting { get; set; }

        public string? ExclusiveFilters { get; set; }

        public string? InclusiveFilters { get; set; }
    }
}