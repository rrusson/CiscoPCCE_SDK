using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingpattern")
    [XmlRoot("results")]
    public class RoutingPatternList : BaseApiBean
    {
        [XmlArray("routingPatterns")]
        [XmlArrayItem("routingPattern")]
        public List<RoutingPattern>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("routingpattern")
        [XmlRoot("results")]
        public class RoutingPatternListList : BaseApiListBean<RoutingPatternList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<RoutingPatternList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<RoutingPatternList>? GetItems() => Items;

            public override void SetItems(List<RoutingPatternList>? value) => Items = value;
        }
    }
}