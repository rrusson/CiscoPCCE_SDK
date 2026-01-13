using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    [XmlRoot("contactShareGroup")]
    public class ContactShareGroup : BaseApiBean
    {
        [XmlElement("acceptQueueIf")]
        public string? AcceptQueueIf { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlArray("contactShareQueues")]
        [XmlArrayItem("contactShareQueue")]
        public List<ReferenceBean>? ContactShareQueues { get; set; }

        [XmlElement("contactShareRule")]
        public required ReferenceBean ContactShareRule { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("queueCount")]
        public int? QueueCount { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}