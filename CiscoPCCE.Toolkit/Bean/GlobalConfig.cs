using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai")
    [XmlRoot("globalConfig")]
    public class GlobalConfig : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("value")]
        public string? Value { get; set; }

        // Path("contactcenterai")
        [XmlRoot("results")]
        public class GlobalConfigList : BaseApiListBean<GlobalConfig>
        {
            [XmlArray("globalConfigs")]
            [XmlArrayItem("globalConfig")]
            public new List<GlobalConfig>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<GlobalConfig>? GetItems() => Items;

            public override void SetItems(List<GlobalConfig>? value) => Items = value;
        }
    }
}