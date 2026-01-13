using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineServiceList : BaseApiList<MachineService>
    {
        [XmlArray("services")]
        [XmlArrayItem("service")]
        public new List<MachineService>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}