using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Operation : BaseApiBean
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