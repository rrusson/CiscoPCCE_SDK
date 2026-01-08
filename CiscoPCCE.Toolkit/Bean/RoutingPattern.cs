using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingpattern")
    [XmlRoot("routingPattern")]
    public class RoutingPattern : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("configParam")]
        public string? ConfigParam { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("destination")]
        public string? Destination { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("pattern")]
        public string? Pattern { get; set; }

        [XmlElement("patternType")]
        public int? PatternType { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("rnaTimeout")]
        public int? RnaTimeout { get; set; }

        [XmlElement("sendToOriginator")]
        public bool? SendToOriginator { get; set; }

        // Path("routingpattern")
        [XmlRoot("results")]
        public class RoutingPatternList : BaseApiListBean<RoutingPattern>
        {
            public override List<RoutingPattern>? GetItems() => Items;

            public override void SetItems(List<RoutingPattern>? value) => Items = value;
        }
    }
}