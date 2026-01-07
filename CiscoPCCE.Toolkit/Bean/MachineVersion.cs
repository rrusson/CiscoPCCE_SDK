using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("versionInfo")]
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

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineVersionList : BaseApiListBean<MachineVersion>
        {
            public override List<MachineVersion>? GetItems() => Items;

            public override void SetItems(List<MachineVersion>? value) => Items = value;
        }
    }
}