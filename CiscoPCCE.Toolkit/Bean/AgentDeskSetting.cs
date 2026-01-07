using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdesksetting")
    [XmlRoot("agentDeskSetting")]
    public class AgentDeskSetting : BaseApiBean
    {
        public AgentStateAfterRONAEnum AgentStateAfterRONA { get; set; }

        public bool? AutoAnswerEnabled { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public int? EmergencyCallMethod { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? IdleReasonRequired { get; set; }

        public int? LogoutNonActivityTime { get; set; }

        public bool? LogoutReasonRequired { get; set; }

        public string? Name { get; set; }

        public int? PlayZipTone { get; set; }

        public new string? RefURL { get; set; }

        public int? RemoteAgentType { get; set; }

        public int? SupervisorAssistCallMethod { get; set; }

        public int? WorkModeTimer { get; set; }

        public int? WrapupDataIncomingMode { get; set; }

        public int? WrapupDataOutgoingMode { get; set; }

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