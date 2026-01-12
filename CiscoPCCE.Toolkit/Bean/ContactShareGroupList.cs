using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("results")]
    public class ContactShareGroupList : BaseApiList<ContactShareGroup>
    {
        [XmlArray("contactShareGroups")]
        [XmlArrayItem("contactShareGroup")]
        public new List<ContactShareGroup>? Items
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