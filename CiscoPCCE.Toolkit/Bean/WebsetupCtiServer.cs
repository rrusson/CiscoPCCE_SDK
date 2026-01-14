using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ctiServer")]
    public class WebsetupCtiServer : BaseApiBean
    {
        [XmlElement("cgId")]
        public string? CgId { get; set; }

        [XmlElement("portIndex")]
        public string? PortIndex { get; set; }

        [XmlElement("side")]
        public string? Side { get; set; }

        [XmlElement("sideAPrivateAddress")]
        public string? SideAPrivateAddress { get; set; }

        [XmlElement("sideAPublicAddress")]
        public string? SideAPublicAddress { get; set; }

        [XmlElement("sideBPrivateAddress")]
        public string? SideBPrivateAddress { get; set; }

        [XmlElement("sideBPublicAddress")]
        public string? SideBPublicAddress { get; set; }
    }
}