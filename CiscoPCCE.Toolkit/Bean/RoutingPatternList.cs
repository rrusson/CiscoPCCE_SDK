using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingpattern")
    [XmlRoot("results")]
    public class RoutingPatternList : BaseApiBean
    {
        [XmlElement("routingPatterns")]
        [XmlElement("routingPattern")]
        public List<RoutingPattern>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("routingpattern")
        [XmlRoot("results")]
        public class RoutingPatternListList : BaseApiListBean<RoutingPatternList>
        {
            public override List<RoutingPatternList>? GetItems() => Items;

            public override void SetItems(List<RoutingPatternList>? value) => Items = value;
        }
    }
}