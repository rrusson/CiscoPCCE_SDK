using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("product")]
    public class ECEProduct : BaseApiBean
    {
        public string? Build { get; set; }

        public string? Description { get; set; }

        public string? InstalledBy { get; set; }

        public string? IntegrationInfo { get; set; }

        public string? Name { get; set; }

        public string? OneOffNumber { get; set; }

        public string? PsCustomizationNumber { get; set; }

        public string? Version { get; set; }
    }
}