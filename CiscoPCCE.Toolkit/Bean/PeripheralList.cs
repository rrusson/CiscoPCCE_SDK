using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("peripheral")
    [XmlRoot("results")]
    public class PeripheralList : BaseApiBean
    {
        [XmlElement("peripherals")]
        [XmlElement("peripheral")]
        public List<PeripheralWithRoutingClient>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("peripheral")
        [XmlRoot("results")]
        public class PeripheralListList : BaseApiListBean<PeripheralList>
        {
            public override List<PeripheralList>? GetItems() => Items;

            public override void SetItems(List<PeripheralList>? value) => Items = value;
        }
    }
}