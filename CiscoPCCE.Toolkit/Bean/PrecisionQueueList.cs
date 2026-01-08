using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("results")]
    public class PrecisionQueueList : BaseApiBean
    {
        [XmlArray("precisionQueues")]
        [XmlArrayItem("precisionQueue")]
        public List<PrecisionQueue>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("precisionqueue")
        [XmlRoot("results")]
        public class PrecisionQueueListList : BaseApiListBean<PrecisionQueueList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<PrecisionQueueList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PrecisionQueueList>? GetItems() => Items;

            public override void SetItems(List<PrecisionQueueList>? value) => Items = value;
        }
    }
}