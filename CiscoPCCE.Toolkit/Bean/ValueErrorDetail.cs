using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ValueErrorDetail : BaseApiBean
    {
        [XmlElement("value")]
        public string? Value { get; set; }
    }
}