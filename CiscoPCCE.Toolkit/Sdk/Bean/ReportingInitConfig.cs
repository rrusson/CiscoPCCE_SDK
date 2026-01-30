using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("reportingConfig")]
    public class ReportingInitConfig : BaseApiBean
    {
        [XmlElement("deviceId")]
        public string? DeviceId { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("ipAddress")]
        public string? IpAddress { get; set; }
    }
}