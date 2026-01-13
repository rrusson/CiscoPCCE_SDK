using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MachineVersionList : BaseApiList<MachineVersion>
    {
        [XmlArray("versionInfos")]
        [XmlArrayItem("versionInfo")]
        public new List<MachineVersion>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}