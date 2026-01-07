using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingpattern")
    [XmlRoot("routingPattern")]
    public class RoutingPattern : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? ConfigParam { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? Destination { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Pattern { get; set; }

        public int? PatternType { get; set; }

        public new string? RefURL { get; set; }

        public int? RnaTimeout { get; set; }

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