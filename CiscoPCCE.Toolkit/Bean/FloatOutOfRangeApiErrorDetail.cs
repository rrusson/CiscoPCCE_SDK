using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class FloatOutOfRangeApiErrorDetail : BaseApiBean
    {
        [XmlElement("max")]
        public float? Max { get; set; }

        [XmlElement("min")]
        public float? Min { get; set; }
    }
}