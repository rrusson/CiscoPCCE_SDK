using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
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