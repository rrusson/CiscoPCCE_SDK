using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
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