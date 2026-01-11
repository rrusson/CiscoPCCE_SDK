using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("results")]
    public class DCAwareRoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("datacenterRoutingTypes")]
        public required DatacenterRoutingTypeBeanList DatacenterRoutingTypes { get; set; }

        [XmlElement("routingTypes")]
        public required RoutingTypeBeanList RoutingTypes { get; set; }

        // Path("routingtype")
        [XmlRoot("results")]
        public class DCAwareRoutingTypeBeanListList : BaseApiListBean<DCAwareRoutingTypeBeanList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<DCAwareRoutingTypeBeanList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DCAwareRoutingTypeBeanList>? GetItems() => Items;

            public override void SetItems(List<DCAwareRoutingTypeBeanList>? value) => Items = value;
        }
    }
}