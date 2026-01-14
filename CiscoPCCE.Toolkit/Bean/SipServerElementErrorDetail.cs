using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class SipServerElementErrorDetail : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("field")]
        public string? Field { get; set; }

        [XmlElement("max")]
        public int? Max { get; set; }

        [XmlElement("min")]
        public int? Min { get; set; }
    }
}