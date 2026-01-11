using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentGlobalSetting : BaseApiBean
    {
        [XmlElement("agentPhoneLineControl")]
        public int? AgentPhoneLineControl { get; set; }

        [XmlElement("baseUrl")]
        public string? BaseUrl { get; set; }

        [XmlElement("defaultDeskSetting")]
        public required ReferenceBean DefaultDeskSetting { get; set; }

        [XmlElement("loginNameCaseSensitivity")]
        public bool? LoginNameCaseSensitivity { get; set; }

        [XmlElement("minimumPasswordLength")]
        public int? MinimumPasswordLength { get; set; }

        [XmlElement("nonACDLineImpact")]
        public int? NonACDLineImpact { get; set; }
    }
}