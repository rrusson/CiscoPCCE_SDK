using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentstatetrace")
    [XmlRoot("agentstatetrace")]
    public class AgentStateTrace : BaseApiBean
    {
        [XmlArray("agents")]
        [XmlArrayItem("agent")]
        public List<AgentBase>? AgentList { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        [XmlElement("refURL")]
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