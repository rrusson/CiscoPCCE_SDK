using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("nodes")]
    public class Nodes : BaseApiBean
    {
        public List<Node>? NodeList { get; set; }
    }
}