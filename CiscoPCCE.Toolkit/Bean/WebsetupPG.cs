using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("peripheralGateway")]
    public class WebsetupPG : BaseApiBean
    {
        [XmlElement("logicalId")]
        public string? LogicalId { get; set; }

        [XmlElement("pgClientType")]
        public string? PgClientType { get; set; }

        [XmlElement("pgId")]
        public string? PgId { get; set; }

        [XmlArray("pims")]
        [XmlArrayItem("pim")]
        public List<WebsetupPim>? Pims { get; set; }

        [XmlElement("portIndex")]
        public string? PortIndex { get; set; }

        [XmlElement("routerSideAPublicAddress")]
        public string? RouterSideAPublicAddress { get; set; }

        [XmlElement("routerSideBPublicAddress")]
        public string? RouterSideBPublicAddress { get; set; }

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