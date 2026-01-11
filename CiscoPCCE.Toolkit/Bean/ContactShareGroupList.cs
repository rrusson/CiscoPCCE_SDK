using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("results")]
    public class ContactShareGroupList : BaseApiBean
    {
        [XmlArray("contactShareGroups")]
        [XmlArrayItem("contactShareGroup")]
        public List<ContactShareGroup>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("contactsharegroup")
        [XmlRoot("results")]
        public class ContactShareGroupListList : BaseApiListBean<ContactShareGroupList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ContactShareGroupList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareGroupList>? GetItems() => Items;

            public override void SetItems(List<ContactShareGroupList>? value) => Items = value;
        }
    }
}