using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("validobjects")
    [XmlRoot("validObjects")]
    public class ValidObjects : BaseApiBean
    {
        [XmlElement("access")]
        public Access Access { get; set; }

        public List<int?>? Ids { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}