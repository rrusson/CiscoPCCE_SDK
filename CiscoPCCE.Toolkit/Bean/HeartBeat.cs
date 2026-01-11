using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class HeartBeat : BaseApiBean
    {
        [XmlElement("interval")]
        public int? Interval { get; set; }

        [XmlElement("requestTimeout")]
        public int? RequestTimeout { get; set; }

        [XmlElement("retryLimit")]
        public int? RetryLimit { get; set; }

        [XmlElement("retryTimeout")]
        public int? RetryTimeout { get; set; }
    }
}