using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("component")]
    public class MachineComponent : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineComponentList : BaseApiListBean<MachineComponent>
        {
            [XmlArray("components")]
            [XmlArrayItem("component")]
            public new List<MachineComponent>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MachineComponent>? GetItems() => Items;

            public override void SetItems(List<MachineComponent>? value) => Items = value;
        }
    }
}