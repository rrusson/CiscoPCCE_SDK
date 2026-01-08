using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class PQStepNotFoundErrorDetail : BaseApiBean
    {
        [XmlElement("pqName")]
        public string? PqName { get; set; }

        [XmlElement("step")]
        public int? Step { get; set; }
    }
}