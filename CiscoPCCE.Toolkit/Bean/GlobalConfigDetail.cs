using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactcenterai")
    [XmlRoot("globalConfigDetail")]
    public class GlobalConfigDetail : BaseApiBean
    {
        [XmlElement("globalConfigs")]
        [XmlElement("globalConfig")]
        public List<GlobalConfig>? GlobalConfigs { get; set; }

        public DateTime? LastSyncTime { get; set; }

        public DateTime? NextAutoSyncTime { get; set; }

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