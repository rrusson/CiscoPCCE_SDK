using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class ConnectionParams : BaseApiBean
    {
        [XmlElement("maxPoolSize")]
        public int? MaxPoolSize { get; set; }

        [XmlElement("minPoolSize")]
        public int? MinPoolSize { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("userId")]
        public string? UserId { get; set; }
    }
}