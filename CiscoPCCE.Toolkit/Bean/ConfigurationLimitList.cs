using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurationlimit")
    [XmlRoot("results")]
    public class ConfigurationLimitList : BaseApiBean
    {
        [XmlArray("configurationlimits")]
        [XmlArrayItem("configurationLimit")]
        public List<ConfigurationLimit>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("configurationlimit")
        [XmlRoot("results")]
        public class ConfigurationLimitListList : BaseApiListBean<ConfigurationLimitList>
        {
            public override List<ConfigurationLimitList>? GetItems() => Items;

            public override void SetItems(List<ConfigurationLimitList>? value) => Items = value;
        }
    }
}