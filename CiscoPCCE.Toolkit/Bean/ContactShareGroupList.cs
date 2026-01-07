using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("results")]
    public class ContactShareGroupList : BaseApiBean
    {
        [XmlElement("contactShareGroups")]
        [XmlElement("contactShareGroup")]
        public List<ContactShareGroup>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("contactsharegroup")
        [XmlRoot("results")]
        public class ContactShareGroupListList : BaseApiListBean<ContactShareGroupList>
        {
            public override List<ContactShareGroupList>? GetItems() => Items;

            public override void SetItems(List<ContactShareGroupList>? value) => Items = value;
        }
    }
}