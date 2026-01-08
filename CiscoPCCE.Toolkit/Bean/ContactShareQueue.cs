using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("contactShareQueue")]
    public class ContactShareQueue : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

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

        [XmlElement("queueType")]
        public string? QueueType { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("targetInstance")]
        public required ReferenceBean TargetInstance { get; set; }

        [XmlElement("targetInstanceId")]
        public int? TargetInstanceId { get; set; }

        [XmlElement("targetQueue")]
        public required TargetQueue TargetQueue { get; set; }

        // Path("contactsharequeue")
        [XmlRoot("results")]
        public class ContactShareQueueList : BaseApiListBean<ContactShareQueue>
        {
            public override List<ContactShareQueue>? GetItems() => Items;

            public override void SetItems(List<ContactShareQueue>? value) => Items = value;
        }
    }
}