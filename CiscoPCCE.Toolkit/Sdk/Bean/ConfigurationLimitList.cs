using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurationlimit")
    [XmlRoot("results")]
    public class ConfigurationLimitList : BaseApiWrappedList<ConfigurationLimit>
    {
        [XmlArray("configurationLimits")]
        [XmlArrayItem("configurationLimit")]
        public new List<ConfigurationLimit>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}