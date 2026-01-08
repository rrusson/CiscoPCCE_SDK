using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("dialednumber")
    [XmlRoot("dialedNumber")]
    public class DialedNumber : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callType")]
        public required ReferenceBean CallType { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlArray("dialedNumberRecords")]
        [XmlArrayItem("dialedNumberRecord")]
        public List<DialedNumberRecord>? DialedNumberRecords { get; set; }

        [XmlElement("dialedNumberString")]
        public string? DialedNumberString { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("mediaRoutingDomain")]
        public required ReferenceBean MediaRoutingDomain { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("pcsEnabledDialedNumberPattern")]
        public string? PcsEnabledDialedNumberPattern { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("ringtoneName")]
        public string? RingtoneName { get; set; }

        [XmlElement("routingType")]
        public int? RoutingType { get; set; }

        // Path("dialednumber")
        [XmlRoot("results")]
        public class DialedNumberList : BaseApiListBean<DialedNumber>
        {
            [XmlArray("dialedNumbers")]
            [XmlArrayItem("dialedNumber")]
            public new List<DialedNumber>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DialedNumber>? GetItems() => Items;

            public override void SetItems(List<DialedNumber>? value) => Items = value;
        }
    }
}