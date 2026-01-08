using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("ClusterConfig")]
    public class ClusterConfig : BaseApiBean
    {
        [XmlElement("secondaryNode")]
        public required SecondaryNode SecondaryNode { get; set; }
    }
}