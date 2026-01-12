using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("results")]
    public class SkillGroupList : BaseApiList<SkillGroupBase>
    {
        [XmlArray("skillGroups")]
        [XmlArrayItem("skillGroup")]
        public new List<SkillGroupBase>? Items
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
