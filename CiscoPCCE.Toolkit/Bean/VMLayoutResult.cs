using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMLayoutResult : BaseApiBean
    {
        [XmlElement("hardwareLayoutType")]
        public string? HardwareLayoutType { get; set; }

        public List<string?>? HostsWithoutProfiles { get; set; }

        [XmlElement("layoutName")]
        public string? LayoutName { get; set; }

        public List<string?>? ProfilesWithoutHosts { get; set; }

        [XmlArray("vmResults")]
        [XmlArrayItem("vmResult")]
        public List<VMServerData>? Results { get; set; }

        [XmlElement("valid")]
        public bool? Valid { get; set; }
    }
}