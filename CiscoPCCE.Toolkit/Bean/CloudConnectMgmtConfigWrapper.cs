using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CloudConnectMgmtConfigWrapper : BaseApiBean
    {
        [XmlElement("cloudConnectMgmtConfig")]
        public required CloudConnectMgmtConfig CloudConnectMgmtConfig { get; set; }
    }
}