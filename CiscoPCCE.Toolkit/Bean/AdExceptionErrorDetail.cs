using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class AdExceptionErrorDetail : BaseApiBean
    {
        [XmlElement("code")]
        public int Code { get; set; }

        [XmlElement("key")]
        public string? Key { get; set; }

        [XmlElement("value")]
        public string? Value { get; set; }
    }
}