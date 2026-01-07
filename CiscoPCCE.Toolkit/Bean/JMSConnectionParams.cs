using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class JMSConnectionParams : BaseApiBean
    {
        public string? BrokerUrl { get; set; }

        public int? MaxPoolSize { get; set; }

        public int? MinPoolSize { get; set; }

        public string? Password { get; set; }

        public string? TopicSchemaUrl { get; set; }

        public string? TopicSchemaUrlPassword { get; set; }

        public string? TopicSchemaUrlUserId { get; set; }

        public string? UserId { get; set; }
    }
}