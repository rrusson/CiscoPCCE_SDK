using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineList : BaseApiBean
    {
        [XmlElement("machines")]
        [XmlElement("machine")]
        public List<MachineHost>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineListList : BaseApiListBean<MachineList>
        {
            public override List<MachineList>? GetItems() => Items;

            public override void SetItems(List<MachineList>? value) => Items = value;
        }
    }
}