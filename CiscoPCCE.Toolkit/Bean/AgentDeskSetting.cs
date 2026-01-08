using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdesksetting")
    [XmlRoot("agentDeskSetting")]
    public class AgentDeskSetting : BaseApiBean
    {
        [XmlElement("agentStateAfterRONA")]
        public AgentStateAfterRONAEnum AgentStateAfterRONA { get; set; }

        [XmlElement("autoAnswerEnabled")]
        public bool? AutoAnswerEnabled { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("emergencyCallMethod")]
        public int? EmergencyCallMethod { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("idleReasonRequired")]
        public bool? IdleReasonRequired { get; set; }

        [XmlElement("logoutNonActivityTime")]
        public int? LogoutNonActivityTime { get; set; }

        [XmlElement("logoutReasonRequired")]
        public bool? LogoutReasonRequired { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("playZipTone")]
        public int? PlayZipTone { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("remoteAgentType")]
        public int? RemoteAgentType { get; set; }

        [XmlElement("supervisorAssistCallMethod")]
        public int? SupervisorAssistCallMethod { get; set; }

        [XmlElement("workModeTimer")]
        public int? WorkModeTimer { get; set; }

        [XmlElement("wrapupDataIncomingMode")]
        public int? WrapupDataIncomingMode { get; set; }

        [XmlElement("wrapupDataOutgoingMode")]
        public int? WrapupDataOutgoingMode { get; set; }

        [XmlElement("acdSharedLineUsage")]
        public int? AcdSharedLineUsage { get; set; }

        // Path("agentdesksetting")
        [XmlRoot("results")]
        public class AgentDeskSettingList : BaseApiListBean<AgentDeskSetting>
        {
            public override List<AgentDeskSetting>? GetItems() => Items;

            public override void SetItems(List<AgentDeskSetting>? value) => Items = value;
        }
    }
}