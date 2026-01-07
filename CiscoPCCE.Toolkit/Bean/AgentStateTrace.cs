using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentstatetrace")
    [XmlRoot("agentstatetrace")]
    public class AgentStateTrace : BaseApiBean
    {
        [XmlElement("agents")]
        [XmlElement("agent")]
        public List<AgentBase>? AgentList { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        public new string? RefURL { get; set; }

        // Path("agentstatetrace")
        [XmlRoot("results")]
        public class AgentStateTraceList : BaseApiListBean<AgentStateTrace>
        {
            public override List<AgentStateTrace>? GetItems() => Items;

            public override void SetItems(List<AgentStateTrace>? value) => Items = value;
        }
    }
}