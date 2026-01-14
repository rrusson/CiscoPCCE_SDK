using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("idsStatus")]
    public class IdsStatus : BaseApiBean
    {
        [XmlElement("state")]
        public string? State { get; set; }
    }
}