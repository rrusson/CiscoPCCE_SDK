using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class Node : BaseApiBean
    {
        public bool? Active { get; set; }

        public string? DeviceType { get; set; }

        public string? HostName { get; set; }

        public string? Ip { get; set; }
    }
}