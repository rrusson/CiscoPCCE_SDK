using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("infrastructure")]
    public class InfrastructureServiceConfig : BaseApiBean
    {
        public int? MaxLogDirectorySize { get; set; }

        public int? MaxLogFileSize { get; set; }

        public string? SyslogBackupServer { get; set; }

        public string? SyslogBackupServerPort { get; set; }

        public string? SyslogSecondaryBackupServer { get; set; }

        public string? SyslogSecondaryBackupServerPort { get; set; }

        public string? SyslogSecondaryServer { get; set; }

        public string? SyslogSecondaryServerPort { get; set; }

        public string? SyslogServer { get; set; }

        public string? SyslogServerPort { get; set; }
    }
}