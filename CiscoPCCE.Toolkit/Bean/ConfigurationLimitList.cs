using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("configurationlimit")
    [XmlRoot("results")]
    public class ConfigurationLimitList : BaseApiList<ConfigurationLimit>
    {
        [XmlArray("configurationLimits")]
        [XmlArrayItem("configurationLimit")]
        public new List<ConfigurationLimit>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}