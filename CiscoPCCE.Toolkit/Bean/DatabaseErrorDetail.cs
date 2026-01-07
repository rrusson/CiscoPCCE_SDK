using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class DatabaseErrorDetail : BaseApiBean
    {
        public DbType DbType { get; set; }

        public string? MachineName { get; set; }

        public Side Side { get; set; }
    }
}