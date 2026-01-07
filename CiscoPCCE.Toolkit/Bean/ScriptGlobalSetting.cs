using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("script")]
    public class ScriptGlobalSetting : BaseApiBean
    {
        public short? RetainScriptVersion { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class ScriptGlobalSettingList : BaseApiListBean<ScriptGlobalSetting>
        {
            public override List<ScriptGlobalSetting>? GetItems() => Items;

            public override void SetItems(List<ScriptGlobalSetting>? value) => Items = value;
        }
    }
}