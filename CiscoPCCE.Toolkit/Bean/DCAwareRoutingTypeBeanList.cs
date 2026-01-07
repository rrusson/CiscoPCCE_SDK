using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class DCAwareRoutingTypeBeanList : BaseApiBean
    {
        public required DatacenterRoutingTypeBeanList DatacenterRoutingTypes { get; set; }

        public required RoutingTypeBeanList RoutingTypes { get; set; }

        // Path("routingtype")
        [XmlRoot("results")]
        public class DCAwareRoutingTypeBeanListList : BaseApiListBean<DCAwareRoutingTypeBeanList>
        {
            public override List<DCAwareRoutingTypeBeanList>? GetItems() => Items;

            public override void SetItems(List<DCAwareRoutingTypeBeanList>? value) => Items = value;
        }
    }
}