using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class CapacityApiErrorDetail : BaseApiBean
    {
        [XmlElement("actual")]
        public int? Actual { get; set; }

        [XmlElement("max")]
        public int? Max { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}