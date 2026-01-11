using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VruPG : BaseApiBean
    {
        [XmlElement("configured")]
        public bool? Configured { get; set; }

        [XmlElement("cvp1Address")]
        public string? Cvp1Address { get; set; }

        [XmlElement("cvp1Password")]
        public string? Cvp1Password { get; set; }

        [XmlElement("cvp1Username")]
        public string? Cvp1Username { get; set; }

        [XmlElement("cvp2Address")]
        public string? Cvp2Address { get; set; }

        [XmlElement("cvp2Password")]
        public string? Cvp2Password { get; set; }

        [XmlElement("cvp2Username")]
        public string? Cvp2Username { get; set; }
    }
}