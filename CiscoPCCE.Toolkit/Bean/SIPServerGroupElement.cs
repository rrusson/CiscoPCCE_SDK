using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sipServerGroupElements")]
    public class SIPServerGroupElement : BaseApiBean
    {
        public string? ElementName { get; set; }

        public string? Port { get; set; }

        public string? Priority { get; set; }

        public string? SecurePort { get; set; }

        public string? Weight { get; set; }
    }
}