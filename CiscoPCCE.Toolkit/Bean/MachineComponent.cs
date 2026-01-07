using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("component")]
    public class MachineComponent : BaseApiBean
    {
        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineComponentList : BaseApiListBean<MachineComponent>
        {
            public override List<MachineComponent>? GetItems() => Items;

            public override void SetItems(List<MachineComponent>? value) => Items = value;
        }
    }
}