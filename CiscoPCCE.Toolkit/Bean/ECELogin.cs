using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("Login")]
    public class ECELogin : BaseApiBean
    {
        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}