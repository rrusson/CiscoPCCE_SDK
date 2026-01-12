using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseEntitlementList : BaseApiList<SmartLicenseEntitlement>
    {
        [XmlArray("smartlicenseentitlements")]
        [XmlArrayItem("smartlicenseentitlement")]
        public new List<SmartLicenseEntitlement>? Items
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