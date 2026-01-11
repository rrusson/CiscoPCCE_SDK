using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("results")]
    public class ContactShareQueueList : BaseApiBean
    {
        [XmlArray("contactShareQueues")]
        [XmlArrayItem("contactShareQueue")]
        public List<ContactShareQueue>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("contactsharequeue")
        [XmlRoot("results")]
        public class ContactShareQueueListList : BaseApiListBean<ContactShareQueueList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ContactShareQueueList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ContactShareQueueList>? GetItems() => Items;

            public override void SetItems(List<ContactShareQueueList>? value) => Items = value;
        }
    }
}