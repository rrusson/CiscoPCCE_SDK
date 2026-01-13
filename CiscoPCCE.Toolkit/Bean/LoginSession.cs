using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class LoginSession : BaseApiBean
    {
        [XmlElement("sessionInactivityTimeout")]
        public int? SessionInactivityTimeout { get; set; }
    }
}