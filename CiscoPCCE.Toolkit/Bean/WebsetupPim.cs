using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("pim")]
    public class WebsetupPim : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("mobileAgentCodec")]
        public string? MobileAgentCodec { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("peripheralId")]
        public string? PeripheralId { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}