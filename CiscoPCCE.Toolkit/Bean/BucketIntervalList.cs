using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("results")]
    public class BucketIntervalList : BaseApiBean
    {
        [XmlArray("bucketIntervals")]
        [XmlArrayItem("bucketInterval")]
        public List<BucketInterval>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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