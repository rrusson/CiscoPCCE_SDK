using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ConnectorConfig : BaseApiBean
    {
        [XmlElement("proxyEnabled")]
        public bool? ProxyEnabled { get; set; }

        [XmlElement("proxyHost")]
        public string? ProxyHost { get; set; }

        [XmlElement("proxyPort")]
        public string? ProxyPort { get; set; }
    }
}