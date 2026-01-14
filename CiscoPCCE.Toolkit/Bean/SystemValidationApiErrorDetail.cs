using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class SystemValidationApiErrorDetail : BaseApiBean
    {
        [XmlElement("actual")]
        public string? Actual { get; set; }

        [XmlElement("expected")]
        public string? Expected { get; set; }

        [XmlElement("max")]
        public int? Max { get; set; }

        [XmlElement("min")]
        public int? Min { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}