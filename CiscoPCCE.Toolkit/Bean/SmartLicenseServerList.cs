using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseServerList : BaseApiBean
    {
        [XmlArray("smartlicenseserverinfos")]
        [XmlArrayItem("smartlicenseserverinfo")]
        public List<SmartLicenseServerInfo>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}