using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("CloudConnectConfig")]
    public class CloudConnectConfig : BaseApiBean
    {
        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("publisherAddress")]
        public string? PublisherAddress { get; set; }

        [XmlElement("subscriberAddress")]
        public string? SubscriberAddress { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}