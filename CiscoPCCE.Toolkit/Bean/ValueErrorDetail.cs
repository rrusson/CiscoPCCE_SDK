using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ValueErrorDetail : BaseApiBean
    {
        [XmlElement("value")]
        public string? Value { get; set; }
    }
}