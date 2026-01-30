using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("reportingServer")]
    public class ReportingServer : BaseApiBean
    {
        [XmlElement("ip")]
        public string? Ip { get; set; }

        [XmlElement("messageBusNumber")]
        public int? MessageBusNumber { get; set; }
    }
}