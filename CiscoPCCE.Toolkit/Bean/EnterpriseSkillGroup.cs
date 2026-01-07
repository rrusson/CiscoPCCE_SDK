using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("enterpriseSkillGroup")]
    public class EnterpriseSkillGroup : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int EntityID { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

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