using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("results")]
    public class PrecisionQueueList : BaseApiBean
    {
        [XmlElement("precisionQueues")]
        [XmlElement("precisionQueue")]
        public List<PrecisionQueue>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("precisionqueue")
        [XmlRoot("results")]
        public class PrecisionQueueListList : BaseApiListBean<PrecisionQueueList>
        {
            public override List<PrecisionQueueList>? GetItems() => Items;

            public override void SetItems(List<PrecisionQueueList>? value) => Items = value;
        }
    }
}