using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("enterpriseSkillGroup")]
    public class EnterpriseSkillGroup : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("entityID")]
        public int EntityID { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("enterpriseroute")
        [XmlRoot("results")]
        public class EnterpriseSkillGroupList : BaseApiListBean<EnterpriseSkillGroup>
        {
            public override List<EnterpriseSkillGroup>? GetItems() => Items;

            public override void SetItems(List<EnterpriseSkillGroup>? value) => Items = value;
        }
    }
}