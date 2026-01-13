using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseProductInfoList : BaseApiList<SmartLicenseProductInfo>
    {
        [XmlArray("smartlicenseproductinfos")]
        [XmlArrayItem("smartlicenseproductinfo")]
        public new List<SmartLicenseProductInfo>? Items
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