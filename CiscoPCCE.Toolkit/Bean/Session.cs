using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Session : BaseApiBean
    {
        [XmlElement("openTimeout")]
        public int? OpenTimeout { get; set; }

        [XmlElement("retryLimit")]
        public int? RetryLimit { get; set; }

        [XmlElement("retryTimeout")]
        public int? RetryTimeout { get; set; }
    }
}