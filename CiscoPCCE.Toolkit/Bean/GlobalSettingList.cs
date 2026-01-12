using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("results")]
    public class GlobalSettingList : BaseApiList<GlobalSetting>
    {
        [XmlArray("globalSettingss")]
        [XmlArrayItem("globalSettings")]
        public new List<GlobalSetting>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}