using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("routingType")]
    public class RoutingTypeBean : BaseApiBean
    {
        public string? MachineType { get; set; }

        public State State { get; set; }

        public int? Type { get; set; }

        // Path("routingtype")
        [XmlRoot("results")]
        public class RoutingTypeBeanList : BaseApiListBean<RoutingTypeBean>
        {
            public override List<RoutingTypeBean>? GetItems() => Items;

            public override void SetItems(List<RoutingTypeBean>? value) => Items = value;
        }
    }
}