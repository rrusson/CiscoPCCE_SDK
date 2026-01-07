using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("notifications")
    [XmlRoot("##default")]
    public class Notification : BaseApiBean
    {
        public Category Category { get; set; }

        public int Count { get; set; }

        // Path("notifications")
        [XmlRoot("results")]
        public class NotificationList : BaseApiListBean<Notification>
        {
            public override List<Notification>? GetItems() => Items;

            public override void SetItems(List<Notification>? value) => Items = value;
        }
    }
}