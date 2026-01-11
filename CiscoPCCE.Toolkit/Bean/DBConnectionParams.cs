using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class DBConnectionParams : BaseApiBean
    {
        [XmlElement("database")]
        public string? Database { get; set; }

        [XmlElement("dbEncoding")]
        public string? DbEncoding { get; set; }

        [XmlElement("dbInstance")]
        public string? DbInstance { get; set; }

        [XmlElement("host")]
        public string? Host { get; set; }

        [XmlElement("maxPoolSize")]
        public int? MaxPoolSize { get; set; }

        [XmlElement("minPoolSize")]
        public int? MinPoolSize { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("port")]
        public int? Port { get; set; }

        [XmlElement("userId")]
        public string? UserId { get; set; }
    }
}