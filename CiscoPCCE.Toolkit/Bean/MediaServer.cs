using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class MediaServer : BaseApiBean
    {
        [XmlElement("ftpEnabled")]
        public bool? FtpEnabled { get; set; }

        [XmlElement("ftpPassword")]
        public string? FtpPassword { get; set; }

        [XmlElement("ftpPort")]
        public int? FtpPort { get; set; }

        [XmlElement("ftpUserName")]
        public string? FtpUserName { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("ip")]
        public string? Ip { get; set; }
    }
}