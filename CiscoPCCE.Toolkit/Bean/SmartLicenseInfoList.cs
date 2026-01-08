using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseInfoList : BaseApiBean
    {
        [XmlArray("smartlicenseinfos")]
        [XmlArrayItem("smartlicenseinfo")]
        public List<SmartLicenseInfo>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseInfoListList : BaseApiListBean<SmartLicenseInfoList>
        {
            public override List<SmartLicenseInfoList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseInfoList>? value) => Items = value;
        }
    }
}