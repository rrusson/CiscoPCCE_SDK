using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseEntitlementList : BaseApiBean
    {
        [XmlArray("smartlicenseentitlements")]
        [XmlArrayItem("smartlicenseentitlement")]
        public List<SmartLicenseEntitlement>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseEntitlementListList : BaseApiListBean<SmartLicenseEntitlementList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<SmartLicenseEntitlementList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SmartLicenseEntitlementList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseEntitlementList>? value) => Items = value;
        }
    }
}