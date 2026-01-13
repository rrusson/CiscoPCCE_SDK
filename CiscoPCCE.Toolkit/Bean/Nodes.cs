using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("nodes")]
    public class Nodes : BaseApiBean
    {
        public List<Node>? NodeList { get; set; }
    }
}