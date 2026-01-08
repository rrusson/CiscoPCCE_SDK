using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reportingServer")]
    public class ReportingServer : BaseApiBean
    {
        [XmlElement("ip")]
        public string? Ip { get; set; }

        [XmlElement("messageBusNumber")]
        public int? MessageBusNumber { get; set; }
    }
}