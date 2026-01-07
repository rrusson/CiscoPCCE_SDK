using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Operation : BaseApiBean
    {
        public required ChangeSet ChangeSet { get; set; }

        public OperationType OperationType { get; set; }

        [XmlElement("refURLs")]
        [XmlElement("refURL")]
        public List<string?>? RefUrls { get; set; }
    }
}