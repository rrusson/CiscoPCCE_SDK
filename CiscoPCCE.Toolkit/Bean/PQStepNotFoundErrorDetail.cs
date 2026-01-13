using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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