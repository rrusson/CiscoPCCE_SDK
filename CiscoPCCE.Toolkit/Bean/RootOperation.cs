using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operation")]
    public class RootOperation : BaseApiBean
    {
        [XmlElement("changeSet")]
        public required ChangeSet ChangeSet { get; set; }

        [XmlElement("operationType")]
        public OperationType OperationType { get; set; }

        [XmlArray("refURLs")]
        [XmlArrayItem("refURL")]
        public List<string?>? RefUrls { get; set; }
        
    }
}