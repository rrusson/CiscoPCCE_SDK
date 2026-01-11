using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineHostList : BaseApiBean
    {
        [XmlArray("hosts")]
        [XmlArrayItem("host")]
        public List<MachineHost>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineHostListList : BaseApiListBean<MachineHostList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<MachineHostList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MachineHostList>? GetItems() => Items;

            public override void SetItems(List<MachineHostList>? value) => Items = value;
        }
    }
}