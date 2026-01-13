using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("database")]
    public class Database : BaseApiBean
    {
        [XmlElement("dataFileSizeMB")]
        public int? DataFileSizeMB { get; set; }

        [XmlElement("databaseType")]
        public DbType DatabaseType { get; set; }

        [XmlElement("drive")]
        public string? Drive { get; set; }

        [XmlElement("logFileSizeMB")]
        public int? LogFileSizeMB { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("side")]
        public Side Side { get; set; }
    }
}