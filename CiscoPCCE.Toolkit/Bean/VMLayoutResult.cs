using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMLayoutResult : BaseApiBean
    {
        public string? HardwareLayoutType { get; set; }

        public List<string?>? HostsWithoutProfiles { get; set; }

        public string? LayoutName { get; set; }

        public List<string?>? ProfilesWithoutHosts { get; set; }

        [XmlElement("vmResults")]
        [XmlElement("vmResult")]
        public List<VMServerData>? Results { get; set; }

        public bool? Valid { get; set; }
    }
}