using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("results")]
    public class SkillGroupList : BaseApiBean
    {
        [XmlArray("skillGroups")]
        [XmlArrayItem("skillGroup")]
        public List<SkillGroupBase>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("skillgroup")
        [XmlRoot("results")]
        public class SkillGroupListList : BaseApiListBean<SkillGroupList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<SkillGroupList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SkillGroupList>? GetItems() => Items;

            public override void SetItems(List<SkillGroupList>? value) => Items = value;
        }
    }
}