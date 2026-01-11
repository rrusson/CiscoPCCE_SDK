using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("CvpConfig")]
    public class CvpConfig : BaseApiBean
    {
        [XmlElement("backupServerIPAddress")]
        public string? BackupServerIPAddress { get; set; }

        [XmlElement("deviceId")]
        public string? DeviceId { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("ipAddress")]
        public string? IpAddress { get; set; }
    }
}