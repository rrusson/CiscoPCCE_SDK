using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CloudConnectMgmtConfigWrapper : BaseApiBean
    {
        public required CloudConnectMgmtConfig CloudConnectMgmtConfig { get; set; }
    }
}