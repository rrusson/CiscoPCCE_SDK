using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentDataCenterSetting : BaseApiBean
    {
        [XmlElement("agentPhoneLineControl")]
        public int? AgentPhoneLineControl { get; set; }

        [XmlElement("baseUrl")]
        public string? BaseUrl { get; set; }

        [XmlElement("defaultDeskSetting")]
        public required ReferenceBean DefaultDeskSetting { get; set; }

        [XmlElement("nonACDLineImpact")]
        public int? NonACDLineImpact { get; set; }
    }
}