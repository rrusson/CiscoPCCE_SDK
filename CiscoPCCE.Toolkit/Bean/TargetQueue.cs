using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("targetQueue")]
    public class TargetQueue : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }
    }
}