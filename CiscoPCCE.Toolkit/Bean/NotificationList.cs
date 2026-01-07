using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("notifications")
    [XmlRoot("results")]
    public class NotificationList : BaseApiBean
    {
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("notifications")
        [XmlRoot("results")]
        public class NotificationListList : BaseApiListBean<NotificationList>
        {
            public override List<NotificationList>? GetItems() => Items;

            public override void SetItems(List<NotificationList>? value) => Items = value;
        }
    }
}