using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseproductinfo")]
    public class SmartLicenseProductInfo : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("privacyEnabled")]
        public int? PrivacyEnabled { get; set; }

        [XmlElement("productDescription")]
        public string? ProductDescription { get; set; }

        [XmlElement("productDisplayName")]
        public string? ProductDisplayName { get; set; }

        [XmlElement("productEnvironment")]
        public int? ProductEnvironment { get; set; }

        [XmlElement("productTag")]
        public string? ProductTag { get; set; }

        [XmlElement("productVersion")]
        public string? ProductVersion { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("smartLicenseProductID")]
        public int? SmartLicenseProductID { get; set; }
    }
}