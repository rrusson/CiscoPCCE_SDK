using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("dialedNumberRecord")]
    public class DialedNumberRecord : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}