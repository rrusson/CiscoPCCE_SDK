using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class Notification : BaseApiBean
    {
        [XmlElement("category")]
        public Category Category { get; set; }

        [XmlElement("count")]
        public int Count { get; set; }
    }
}