using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("bucketInterval")]
    public class BucketInterval : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? UpperBound1 { get; set; }

        public int? UpperBound2 { get; set; }

        public int? UpperBound3 { get; set; }

        public int? UpperBound4 { get; set; }

        public int? UpperBound5 { get; set; }

        public int? UpperBound6 { get; set; }

        public int? UpperBound7 { get; set; }

        public int? UpperBound8 { get; set; }

        public int? UpperBound9 { get; set; }

        // Path("bucketinterval")
        [XmlRoot("results")]
        public class BucketIntervalList : BaseApiListBean<BucketInterval>
        {
            public override List<BucketInterval>? GetItems() => Items;

            public override void SetItems(List<BucketInterval>? value) => Items = value;
        }
    }
}