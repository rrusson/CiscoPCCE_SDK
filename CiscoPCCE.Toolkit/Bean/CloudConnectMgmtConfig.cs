using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CloudConnectMgmtConfig : BaseApiBean
    {
        [XmlElement("connCfg")]
        public required ConnectorConfig ConnCfg { get; set; }

        [XmlElement("lastUpdatedTimestamp")]
        public long? LastUpdatedTimestamp { get; set; }
    }
}