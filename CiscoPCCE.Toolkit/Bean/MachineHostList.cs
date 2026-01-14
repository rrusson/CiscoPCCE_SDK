using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineHostList : BaseApiWrappedList<MachineHost>
    {
        [XmlArray("machines")]
        [XmlArrayItem("machine")]
        public new List<MachineHost>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}