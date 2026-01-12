using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("role")
    [XmlRoot("results")]
    public class RoleList : BaseApiList<Role>
    {
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public new List<Role>? Items
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