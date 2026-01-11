using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class JMSConnectionParams : BaseApiBean
    {
        [XmlElement("brokerUrl")]
        public string? BrokerUrl { get; set; }

        [XmlElement("maxPoolSize")]
        public int? MaxPoolSize { get; set; }

        [XmlElement("minPoolSize")]
        public int? MinPoolSize { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("topicSchemaUrl")]
        public string? TopicSchemaUrl { get; set; }

        [XmlElement("topicSchemaUrlPassword")]
        public string? TopicSchemaUrlPassword { get; set; }

        [XmlElement("topicSchemaUrlUserId")]
        public string? TopicSchemaUrlUserId { get; set; }

        [XmlElement("userId")]
        public string? UserId { get; set; }
    }
}