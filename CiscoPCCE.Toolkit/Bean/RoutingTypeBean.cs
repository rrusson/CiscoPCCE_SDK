using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("routingType")]
    public class RoutingTypeBean : BaseApiBean
    {
        [XmlElement("machineType")]
        public string? MachineType { get; set; }

        [XmlElement("state")]
        public State State { get; set; }

        [XmlElement("type")]
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