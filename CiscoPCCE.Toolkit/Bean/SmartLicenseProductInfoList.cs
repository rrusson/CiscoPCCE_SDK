using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseProductInfoList : BaseApiBean
    {
        [XmlArray("smartlicenseproductsinfo")]
        [XmlArrayItem("smartlicenseproductinfo")]
        public List<SmartLicenseProductInfo>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseProductInfoListList : BaseApiListBean<SmartLicenseProductInfoList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<SmartLicenseProductInfoList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SmartLicenseProductInfoList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseProductInfoList>? value) => Items = value;
        }
    }
}