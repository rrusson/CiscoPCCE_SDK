using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class TimeZoneRef : BaseApiBean
    {
        [XmlElement("displayName")]
        public string? DisplayName { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}