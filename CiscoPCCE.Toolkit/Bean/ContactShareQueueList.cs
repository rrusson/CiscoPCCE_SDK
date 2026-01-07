using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("results")]
    public class ContactShareQueueList : BaseApiBean
    {
        [XmlElement("contactShareQueues")]
        [XmlElement("contactShareQueue")]
        public List<ContactShareQueue>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("contactsharequeue")
        [XmlRoot("results")]
        public class ContactShareQueueListList : BaseApiListBean<ContactShareQueueList>
        {
            public override List<ContactShareQueueList>? GetItems() => Items;

            public override void SetItems(List<ContactShareQueueList>? value) => Items = value;
        }
    }
}