using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("product")]
    public class ECEProduct : BaseApiBean
    {
        [XmlElement("build")]
        public string? Build { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("installedBy")]
        public string? InstalledBy { get; set; }

        [XmlElement("integrationInfo")]
        public string? IntegrationInfo { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("oneOffNumber")]
        public string? OneOffNumber { get; set; }

        [XmlElement("psCustomizationNumber")]
        public string? PsCustomizationNumber { get; set; }

        [XmlElement("version")]
        public string? Version { get; set; }
    }
}