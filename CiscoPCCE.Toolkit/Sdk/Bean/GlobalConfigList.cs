using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai")
    [XmlRoot("results")]
    public class GlobalConfigList : BaseApiList<GlobalConfig>
    {
        [XmlArray("globalConfigs")]
        [XmlArrayItem("globalConfig")]
        public new List<GlobalConfig>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}