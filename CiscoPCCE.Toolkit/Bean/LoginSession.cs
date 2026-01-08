using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class LoginSession : BaseApiBean
    {
        [XmlElement("sessionInactivityTimeout")]
        public int? SessionInactivityTimeout { get; set; }
    }
}