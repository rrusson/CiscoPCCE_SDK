using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("activation")]
    public class ReportingActivation : BaseApiBean
    {
        [XmlElement("messageBusNumber")]
        public int? MessageBusNumber { get; set; }

        [XmlElement("port")]
        public int? Port { get; set; }

        [XmlElement("subsystemNumber")]
        public int? SubsystemNumber { get; set; }
    }
}