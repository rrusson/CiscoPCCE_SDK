using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class DatabaseErrorDetail : BaseApiBean
    {
        [XmlElement("dbType")]
        public DbType DbType { get; set; }

        [XmlElement("machineName")]
        public string? MachineName { get; set; }

        [XmlElement("side")]
        public Side Side { get; set; }
    }
}