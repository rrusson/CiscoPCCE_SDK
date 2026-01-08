using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineList : BaseApiBean
    {
        [XmlArray("machines")]
        [XmlArrayItem("machine")]
        public List<MachineHost>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
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