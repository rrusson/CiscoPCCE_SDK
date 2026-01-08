using System.Xml.Serialization;

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
            public override List<GlobalConfigDetail>? GetItems() => Items;

            public override void SetItems(List<GlobalConfigDetail>? value) => Items = value;
        }
    }
}