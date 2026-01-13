using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("initialize")
    [XmlRoot("##default")]
    public class InitialSettings : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("cmSideA")]
        public required ReferenceBean CmSideA { get; set; }

        [XmlElement("cmSideB")]
        public required ReferenceBean CmSideB { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("hardwareLayoutType")]
        public int? HardwareLayoutType { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("mobileAgentCodec")]
        public string? MobileAgentCodec { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("serviceAccountPassword")]
        public string? ServiceAccountPassword { get; set; }

        [XmlElement("serviceAccountUserName")]
        public string? ServiceAccountUserName { get; set; }
    }
}