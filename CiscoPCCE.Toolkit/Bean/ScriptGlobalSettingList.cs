using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("results")]
    public class ScriptGlobalSettingList : BaseApiList<ScriptGlobalSetting>
    {
        [XmlArray("scripts")]
        [XmlArrayItem("script")]
        public new List<ScriptGlobalSetting>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}