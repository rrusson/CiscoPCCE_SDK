using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineComponentList : BaseApiList<MachineComponent>
    {
        [XmlArray("components")]
        [XmlArrayItem("component")]
        public new List<MachineComponent>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}