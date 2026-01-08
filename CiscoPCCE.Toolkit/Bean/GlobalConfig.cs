using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai")
    [XmlRoot("globalConfig")]
    public class GlobalConfig : BaseApiBean
    {
        private string? value;

        [XmlElement("name")]
        public string? Name { get; set; }

        public string? Value
        {
            get => value;
            set => _ = value;
        }

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