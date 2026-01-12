using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("bucketinterval")
    [XmlRoot("bucketInterval")]
    public class BucketInterval : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("upperBound1")]
        public int? UpperBound1 { get; set; }

        [XmlElement("upperBound2")]
        public int? UpperBound2 { get; set; }

        [XmlElement("upperBound3")]
        public int? UpperBound3 { get; set; }

        [XmlElement("upperBound4")]
        public int? UpperBound4 { get; set; }

        [XmlElement("upperBound5")]
        public int? UpperBound5 { get; set; }

        [XmlElement("upperBound6")]
        public int? UpperBound6 { get; set; }

        [XmlElement("upperBound7")]
        public int? UpperBound7 { get; set; }

        [XmlElement("upperBound8")]
        public int? UpperBound8 { get; set; }

        [XmlElement("upperBound9")]
        public int? UpperBound9 { get; set; }
        
    }
}