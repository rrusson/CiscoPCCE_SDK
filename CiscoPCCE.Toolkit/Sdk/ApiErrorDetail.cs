using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Sdk
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
