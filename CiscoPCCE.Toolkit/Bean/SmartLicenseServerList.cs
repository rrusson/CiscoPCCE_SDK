using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("results")]
    public class SmartLicenseServerList : BaseApiBean
    {
        [XmlElement("smartlicenseserverinfos")]
        [XmlElement("smartlicenseserverinfo")]
        public List<SmartLicenseServerInfo>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseServerListList : BaseApiListBean<SmartLicenseServerList>
        {
            public override List<SmartLicenseServerList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseServerList>? value) => Items = value;
        }
    }
}