using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("MRconfig")]
    public class MRConfig : BaseApiBean
    {
        public bool? Enabled { get; set; }

        public string? HostA { get; set; }

        public string? HostB { get; set; }

        public int Port { get; set; }
    }
}