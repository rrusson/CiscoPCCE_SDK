using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("generalsetting")
    [XmlRoot("results")]
    public class GeneralSettingList : BaseApiList<GeneralSetting>
    {
        [XmlArray("generalSettingss")]
        [XmlArrayItem("generalSettings")]
        public new List<GeneralSetting>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}