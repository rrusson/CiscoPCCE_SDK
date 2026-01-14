using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("timeZone")]
    public class TimeZone : BaseApiBean
    {
        [XmlElement("bias")]
        public int? Bias { get; set; }

        [XmlElement("displayName")]
        public string? DisplayName { get; set; }

        [XmlElement("dstName")]
        public string? DstName { get; set; }

        [XmlElement("dstObserved")]
        public bool? DstObserved { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("stdName")]
        public string? StdName { get; set; }
    }
}