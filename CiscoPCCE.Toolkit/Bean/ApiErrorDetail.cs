using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class ApiErrorDetail : BaseApiBean
    {
        [XmlElement("min")]
        public int? Min { get; set; }

        [XmlElement("max")]
        public int? Max { get; set; }
    }
}
