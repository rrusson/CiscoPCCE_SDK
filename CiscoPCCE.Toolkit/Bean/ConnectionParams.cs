using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class ConnectionParams : BaseApiBean
    {
        public int? MaxPoolSize { get; set; }

        public int? MinPoolSize { get; set; }

        public string? Password { get; set; }

        public string? UserId { get; set; }
    }
}