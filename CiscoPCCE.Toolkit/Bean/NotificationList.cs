using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("notifications")
    [XmlRoot("results")]
    public class NotificationList : BaseApiBean
    {
        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("notifications")
        [XmlRoot("results")]
        public class NotificationListList : BaseApiListBean<NotificationList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<NotificationList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<NotificationList>? GetItems() => Items;

            public override void SetItems(List<NotificationList>? value) => Items = value;
        }
    }
}