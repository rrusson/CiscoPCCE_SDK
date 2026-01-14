using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("masterscript")
    [XmlRoot("results")]
    public class MasterScriptList : BaseApiWrappedList<MasterScript>
    {
        [XmlArray("masterScripts")]
        [XmlArrayItem("masterScript")]
        public new List<MasterScript>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}