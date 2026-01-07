using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseProductInfoList : BaseApiBean
    {
        [XmlElement("smartlicenseproductsinfo")]
        [XmlElement("smartlicenseproductinfo")]
        public List<SmartLicenseProductInfo>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseProductInfoListList : BaseApiListBean<SmartLicenseProductInfoList>
        {
            public override List<SmartLicenseProductInfoList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseProductInfoList>? value) => Items = value;
        }
    }
}