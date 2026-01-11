using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("role")
    [XmlRoot("results")]
    public class RoleList : BaseApiBean
    {
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<Role>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("role")
        [XmlRoot("results")]
        public class RoleListList : BaseApiListBean<RoleList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<RoleList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<RoleList>? GetItems() => Items;

            public override void SetItems(List<RoleList>? value) => Items = value;
        }
    }
}