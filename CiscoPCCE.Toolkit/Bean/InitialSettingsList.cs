using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("results")]
    public class InitialSettingsList : BaseApiList<InitialSettings>
    {
        [XmlArray("##defaults")]
        [XmlArrayItem("##default")]
        public new List<InitialSettings>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}