using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("results")]
    public class EnterpriseSkillGroupList : BaseApiList<EnterpriseSkillGroup>
    {
        [XmlArray("enterpriseSkillGroups")]
        [XmlArrayItem("enterpriseSkillGroup")]
        public new List<EnterpriseSkillGroup>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}