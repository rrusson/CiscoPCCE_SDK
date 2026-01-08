using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("notifications")
    [XmlRoot("##default")]
    public class Notification : BaseApiBean
    {
        [XmlElement("category")]
        public Category Category { get; set; }

        [XmlElement("count")]
        public int Count { get; set; }

        // Path("notifications")
        [XmlRoot("results")]
        public class NotificationList : BaseApiListBean<Notification>
        {
            [XmlArray("##defaults")]
            [XmlArrayItem("##default")]
            public new List<Notification>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Notification>? GetItems() => Items;

            public override void SetItems(List<Notification>? value) => Items = value;
        }
    }
}