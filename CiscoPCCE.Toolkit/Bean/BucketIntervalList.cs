using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("results")]
    public class BucketIntervalList : BaseApiList<BucketInterval>
    {
        [XmlArray("bucketIntervals")]
        [XmlArrayItem("bucketInterval")]
        public new List<BucketInterval>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}