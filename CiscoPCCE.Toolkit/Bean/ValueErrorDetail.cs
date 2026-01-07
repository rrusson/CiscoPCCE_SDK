using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ValueErrorDetail : BaseApiBean
    {
        public string? Value { get; set; }
    }
}