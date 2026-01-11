using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai")
    [XmlRoot("globalConfigDetail")]
    public class GlobalConfigDetail : BaseApiBean
    {
        [XmlArray("globalConfigs")]
        [XmlArrayItem("globalConfig")]
        public List<GlobalConfig>? GlobalConfigs { get; set; }

        [XmlElement("lastSyncTime")]
        public DateTime? LastSyncTime { get; set; }

        [XmlElement("nextAutoSyncTime")]
        public DateTime? NextAutoSyncTime { get; set; }

        [XmlElement("status")]
        public required Status Status { get; set; }

        // Path("contactcenterai")
        [XmlRoot("results")]
        public class GlobalConfigDetailList : BaseApiListBean<GlobalConfigDetail>
        {
            [XmlArray("globalConfigDetails")]
            [XmlArrayItem("globalConfigDetail")]
            public new List<GlobalConfigDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<GlobalConfigDetail>? GetItems() => Items;

            public override void SetItems(List<GlobalConfigDetail>? value) => Items = value;
        }
    }
}