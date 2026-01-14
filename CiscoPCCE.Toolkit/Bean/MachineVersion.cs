using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("versionInfo")]
    public class MachineVersion : BaseApiBean
    {
        [XmlElement("buildDate")]
        public DateTime? BuildDate { get; set; }

        [XmlElement("buildNumber")]
        public string? BuildNumber { get; set; }

        [XmlElement("dropNumber")]
        public string? DropNumber { get; set; }

        [XmlElement("esNumber")]
        public string? EsNumber { get; set; }

        [XmlElement("patchVersion")]
        public string? PatchVersion { get; set; }

        [XmlElement("srNumber")]
        public string? SrNumber { get; set; }

        [XmlElement("version")]
        public string? Version { get; set; }
    }
}