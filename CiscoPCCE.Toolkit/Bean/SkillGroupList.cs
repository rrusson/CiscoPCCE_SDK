using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("results")]
    public class SkillGroupList : BaseApiBean
    {
        [XmlElement("skillGroups")]
        [XmlElement("skillGroup")]
        public List<SkillGroupBase>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("skillgroup")
        [XmlRoot("results")]
        public class SkillGroupListList : BaseApiListBean<SkillGroupList>
        {
            public override List<SkillGroupList>? GetItems() => Items;

            public override void SetItems(List<SkillGroupList>? value) => Items = value;
        }
    }
}