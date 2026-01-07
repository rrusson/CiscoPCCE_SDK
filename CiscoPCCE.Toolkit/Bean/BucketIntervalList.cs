using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("results")]
    public class BucketIntervalList : BaseApiBean
    {
        [XmlElement("bucketIntervals")]
        [XmlElement("bucketInterval")]
        public List<BucketInterval>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("bucketinterval")
        [XmlRoot("results")]
        public class BucketIntervalListList : BaseApiListBean<BucketIntervalList>
        {
            public override List<BucketIntervalList>? GetItems() => Items;

            public override void SetItems(List<BucketIntervalList>? value) => Items = value;
        }
    }
}