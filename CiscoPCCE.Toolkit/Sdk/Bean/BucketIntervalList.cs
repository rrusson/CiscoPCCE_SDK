using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("results")]
    public class BucketIntervalList : BaseApiWrappedList<BucketInterval>
    {
        [XmlArray("bucketIntervals")]
        [XmlArrayItem("bucketInterval")]
        public new List<BucketInterval>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}