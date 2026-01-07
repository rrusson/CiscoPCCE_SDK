using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("results")]
    public class EnterpriseSkillGroupList : BaseApiBean
    {
        [XmlElement("EnterpriseSkillGroups")]
        [XmlElement("EnterpriseSkillGroup")]
        public List<EnterpriseSkillGroup>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("enterpriseroute")
        [XmlRoot("results")]
        public class EnterpriseSkillGroupListList : BaseApiListBean<EnterpriseSkillGroupList>
        {
            public override List<EnterpriseSkillGroupList>? GetItems() => Items;

            public override void SetItems(List<EnterpriseSkillGroupList>? value) => Items = value;
        }
    }
}