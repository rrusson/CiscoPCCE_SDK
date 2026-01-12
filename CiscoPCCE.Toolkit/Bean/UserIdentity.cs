using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("useridentity")
    [XmlRoot("userIdentity")]
    public class UserIdentity : BaseApiBean
    {
        [XmlElement("displayName")]
        public string? DisplayName { get; set; }

        [XmlElement("firstName")]
        public string? FirstName { get; set; }

        [XmlElement("lastName")]
        public string? LastName { get; set; }

        [XmlElement("role")]
        public string? Role { get; set; }

        [XmlElement("username")]
        public string? Username { get; set; }
        
    }
}