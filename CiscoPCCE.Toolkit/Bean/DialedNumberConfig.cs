using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("dialedNumberConfig")]
    public class DialedNumberConfig : BaseApiBean
    {
        [XmlElement("dialedNumber")]
        public string? DialedNumber { get; set; }

        [XmlElement("postCallSurveyNumber")]
        public string? PostCallSurveyNumber { get; set; }

        [XmlElement("ringtone")]
        public string? Ringtone { get; set; }
    }
}