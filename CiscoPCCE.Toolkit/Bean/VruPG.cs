using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VruPG : BaseApiBean
    {
        [XmlElement("configured")]
        public bool? Configured { get; set; }

        public string? Cvp1Address { get; set; }

        public string? Cvp1Password { get; set; }

        public string? Cvp1Username { get; set; }

        public string? Cvp2Address { get; set; }

        public string? Cvp2Password { get; set; }

        public string? Cvp2Username { get; set; }
    }
}