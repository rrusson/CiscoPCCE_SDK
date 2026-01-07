using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ValueListErrorDetail : BaseApiBean
    {
        [XmlElement("invalidValues")]
        [XmlElement("invalidValue")]
        public List<string?>? InvalidValues { get; set; }
    }
}