using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("peripheral")
    [XmlRoot("results")]
    public class PeripheralList : BaseApiBean
    {
        [XmlArray("peripherals")]
        [XmlArrayItem("peripheral")]
        public List<PeripheralWithRoutingClient>? Items { get; set; }

    [XmlElement("pageInfo")]
    public required PageInfo PageInfo { get; set; }

    [XmlElement("permissionInfo")]
    public required PermissionInfo PermissionInfo { get; set; }

        // Path("peripheral")
        [XmlRoot("results")]
        public class PeripheralListList : BaseApiListBean<PeripheralList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<PeripheralList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PeripheralList>? GetItems() => Items;

            public override void SetItems(List<PeripheralList>? value) => Items = value;
        }
    }
}