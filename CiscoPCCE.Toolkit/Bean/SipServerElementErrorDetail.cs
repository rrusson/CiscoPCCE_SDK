using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
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