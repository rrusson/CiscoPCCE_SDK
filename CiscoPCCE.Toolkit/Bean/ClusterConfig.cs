using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("ClusterConfig")]
    public class ClusterConfig : BaseApiBean
    {
        [XmlElement("secondaryNode")]
        public required SecondaryNode SecondaryNode { get; set; }
    }
}