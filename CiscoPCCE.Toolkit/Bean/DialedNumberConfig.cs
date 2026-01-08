using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dialedNumberConfig")]
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