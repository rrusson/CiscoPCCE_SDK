using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("dialedNumber")]
    public class DialedNumber : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean CallType { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        [XmlElement("dialedNumberRecords")]
        [XmlElement("dialedNumberRecord")]
        public List<DialedNumberRecord>? DialedNumberRecords { get; set; }

        public string? DialedNumberString { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public required ReferenceBean MediaRoutingDomain { get; set; }

        public string? Name { get; set; }

        public string? PcsEnabledDialedNumberPattern { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        public new string? RefURL { get; set; }

        public string? RingtoneName { get; set; }

        public int? RoutingType { get; set; }

        // Path("dialednumber")
        [XmlRoot("results")]
        public class DialedNumberList : BaseApiListBean<DialedNumber>
        {
            public override List<DialedNumber>? GetItems() => Items;

            public override void SetItems(List<DialedNumber>? value) => Items = value;
        }
    }
}