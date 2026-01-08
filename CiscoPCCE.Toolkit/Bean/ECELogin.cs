using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Login")]
    public class ECELogin : BaseApiBean
    {
        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}