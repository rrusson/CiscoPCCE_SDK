using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseproductinfo")]
    public class SmartLicenseProductInfo : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public int? PrivacyEnabled { get; set; }

        public string? ProductDescription { get; set; }

        public string? ProductDisplayName { get; set; }

        public int? ProductEnvironment { get; set; }

        public string? ProductTag { get; set; }

        public string? ProductVersion { get; set; }

        public new string? RefURL { get; set; }

        public int? SmartLicenseProductID { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseProductInfoList : BaseApiListBean<SmartLicenseProductInfo>
        {
            public override List<SmartLicenseProductInfo>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseProductInfo>? value) => Items = value;
        }
    }
}