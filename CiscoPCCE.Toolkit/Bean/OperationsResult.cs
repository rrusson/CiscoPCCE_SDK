using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("operation")
    [XmlRoot("operationsResult")]
    public class OperationsResult : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors ApiErrors { get; set; }

        [XmlElement("createdObjects")]
        public required ChangeSet CreatedObjects { get; set; }

        [XmlElement("status")]
        public StatusType Status { get; set; }
    }
}