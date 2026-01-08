using System.Xml.Serialization;

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

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseServerListList : BaseApiListBean<SmartLicenseServerList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<SmartLicenseServerList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SmartLicenseServerList>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseServerList>? value) => Items = value;
        }
    }
}