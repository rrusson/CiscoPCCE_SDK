using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseInfoList : BaseApiList<SmartLicenseInfo>
    {
        [XmlArray("smartlicenseinfos")]
        [XmlArrayItem("smartlicenseinfo")]
        public new List<SmartLicenseInfo>? Items
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