using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseEntitlementList : BaseApiBean
    {
        [XmlElement("smartlicenseentitlements")]
        [XmlElement("smartlicenseentitlement")]
        public List<SmartLicenseEntitlement>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseEntitlementListList : BaseApiListBean<SmartLicenseEntitlementList>
        {
            public override List<SmartLicenseEntitlementList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseEntitlementList>? value) => Items = value;
        }
    }
}