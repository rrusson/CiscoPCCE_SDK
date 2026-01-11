using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("versionInfos")]
            [XmlArrayItem("versionInfo")]
            public new List<MachineVersion>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MachineVersion>? GetItems() => Items;

            public override void SetItems(List<MachineVersion>? value) => Items = value;
        }
    }
}