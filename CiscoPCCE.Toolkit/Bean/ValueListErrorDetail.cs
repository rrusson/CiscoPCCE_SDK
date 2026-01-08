using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class ValueListErrorDetail : BaseApiBean
    {
        [XmlArray("invalidValues")]
        [XmlArrayItem("invalidValue")]
        public List<string?>? InvalidValues { get; set; }
    }
}