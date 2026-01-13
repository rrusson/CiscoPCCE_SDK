using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class StreamingConnectionParams : BaseApiBean
    {
        [XmlElement("ldPassword")]
        public string? LdPassword { get; set; }

        [XmlElement("ldSchemaUrl")]
        public string? LdSchemaUrl { get; set; }

        [XmlElement("ldServiceIP")]
        public string? LdServiceIP { get; set; }

        [XmlElement("ldServicePort")]
        public int? LdServicePort { get; set; }

        [XmlElement("ldTokenUrl")]
        public string? LdTokenUrl { get; set; }

        [XmlElement("ldUserId")]
        public string? LdUserId { get; set; }

        [XmlElement("maxPoolSize")]
        public int? MaxPoolSize { get; set; }

        [XmlElement("minPoolSize")]
        public int? MinPoolSize { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("userId")]
        public string? UserId { get; set; }

        [XmlElement("webSocketPort")]
        public int? WebSocketPort { get; set; }
    }
}