using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<BucketIntervalList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<BucketIntervalList>? GetItems() => Items;

            public override void SetItems(List<BucketIntervalList>? value) => Items = value;
        }
    }
}