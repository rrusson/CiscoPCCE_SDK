using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    [XmlRoot("script")]
    public class ScriptGlobalSetting : BaseApiBean
    {
        [XmlElement("retainScriptVersion")]
        public short? RetainScriptVersion { get; set; }

        // Path("globalsetting")
        [XmlRoot("results")]
        public class ScriptGlobalSettingList : BaseApiListBean<ScriptGlobalSetting>
        {
            [XmlArray("scripts")]
            [XmlArrayItem("script")]
            public new List<ScriptGlobalSetting>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ScriptGlobalSetting>? GetItems() => Items;

            public override void SetItems(List<ScriptGlobalSetting>? value) => Items = value;
        }
    }
}