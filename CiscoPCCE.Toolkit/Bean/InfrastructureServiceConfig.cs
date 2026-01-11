using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("infrastructure")]
    public class InfrastructureServiceConfig : BaseApiBean
    {
        [XmlElement("maxLogDirectorySize")]
        public int? MaxLogDirectorySize { get; set; }

        [XmlElement("maxLogFileSize")]
        public int? MaxLogFileSize { get; set; }

        [XmlElement("syslogBackupServer")]
        public string? SyslogBackupServer { get; set; }

        [XmlElement("syslogBackupServerPort")]
        public string? SyslogBackupServerPort { get; set; }

        [XmlElement("syslogSecondaryBackupServer")]
        public string? SyslogSecondaryBackupServer { get; set; }

        [XmlElement("syslogSecondaryBackupServerPort")]
        public string? SyslogSecondaryBackupServerPort { get; set; }

        [XmlElement("syslogSecondaryServer")]
        public string? SyslogSecondaryServer { get; set; }

        [XmlElement("syslogSecondaryServerPort")]
        public string? SyslogSecondaryServerPort { get; set; }

        [XmlElement("syslogServer")]
        public string? SyslogServer { get; set; }

        [XmlElement("syslogServerPort")]
        public string? SyslogServerPort { get; set; }
    }
}