using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentPG : BaseApiBean
    {
        [XmlElement("cmSubSideA")]
        public required ReferenceBean CmSubSideA { get; set; }

        [XmlElement("cmSubSideB")]
        public required ReferenceBean CmSubSideB { get; set; }

        [XmlElement("configured")]
        public bool? Configured { get; set; }

        [XmlElement("finessePassword")]
        public string? FinessePassword { get; set; }

        [XmlElement("finessePrimaryAddress")]
        public string? FinessePrimaryAddress { get; set; }

        [XmlElement("finesseUserName")]
        public string? FinesseUserName { get; set; }

        [XmlElement("mobileAgentCodec")]
        public string? MobileAgentCodec { get; set; }
    }
}