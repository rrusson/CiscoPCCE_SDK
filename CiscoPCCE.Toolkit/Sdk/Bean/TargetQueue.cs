using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("targetQueue")]
    public class TargetQueue : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }
    }
}