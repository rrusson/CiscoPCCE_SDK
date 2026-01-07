using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("nodes")]
    public class Nodes : BaseApiBean
    {
        public List<Node>? NodeList { get; set; }
    }
}