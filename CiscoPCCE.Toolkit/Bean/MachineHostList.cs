using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineHostList : BaseApiBean
    {
        [XmlElement("hosts")]
        [XmlElement("host")]
        public List<MachineHost>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineHostListList : BaseApiListBean<MachineHostList>
        {
            public override List<MachineHostList>? GetItems() => Items;

            public override void SetItems(List<MachineHostList>? value) => Items = value;
        }
    }
}