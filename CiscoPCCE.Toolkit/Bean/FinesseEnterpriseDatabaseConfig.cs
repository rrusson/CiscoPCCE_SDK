using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("EnterpriseDatabaseConfig")]
    public class FinesseEnterpriseDatabaseConfig : BaseApiBean
    {
        [XmlElement("backupHost")]
        public string? BackupHost { get; set; }

        [XmlElement("databaseName")]
        public string? DatabaseName { get; set; }

        [XmlElement("domain")]
        public string? Domain { get; set; }

        [XmlElement("host")]
        public string? Host { get; set; }

        [XmlElement("password")]
        public string? Password { get; set; }

        [XmlElement("port")]
        public int Port { get; set; }

        [XmlElement("username")]
        public string? UserName { get; set; }
    }
}