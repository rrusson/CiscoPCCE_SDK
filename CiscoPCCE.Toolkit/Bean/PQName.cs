using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("pqName")]
    public class PQName : BaseApiBean
    {
        [XmlElement("enterpriseName")]
        public string? EnterpriseName { get; set; }

        [XmlElement("pqID")]
        public int? pqID { get; set; }

        [XmlElement("pqURL")]
        public string? pqURL { get; set; }
    }
}