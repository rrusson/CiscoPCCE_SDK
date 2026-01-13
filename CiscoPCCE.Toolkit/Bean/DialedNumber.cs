using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("dialedNumber")]
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
    }
}