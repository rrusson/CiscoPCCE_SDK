using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("datacenterRoutingType")]
    public class DatacenterRoutingTypeBean : BaseApiBean
    {
        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("routingTypes")]
        public required RoutingTypeBeanList RoutingTypes { get; set; }

        // Path("routingtype")
        [XmlRoot("results")]
        public class DatacenterRoutingTypeBeanList : BaseApiListBean<DatacenterRoutingTypeBean>
        {
            [XmlArray("datacenterRoutingTypes")]
            [XmlArrayItem("datacenterRoutingType")]
            public new List<DatacenterRoutingTypeBean>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DatacenterRoutingTypeBean>? GetItems() => Items;

            public override void SetItems(List<DatacenterRoutingTypeBean>? value) => Items = value;
        }
    }
}