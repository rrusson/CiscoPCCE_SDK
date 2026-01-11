using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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