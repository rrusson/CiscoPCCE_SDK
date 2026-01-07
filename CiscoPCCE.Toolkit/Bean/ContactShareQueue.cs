using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharequeue")
    [XmlRoot("contactShareQueue")]
    public class ContactShareQueue : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public string? QueueType { get; set; }

        public new string? RefURL { get; set; }

        public required ReferenceBean TargetInstance { get; set; }

        public int? TargetInstanceId { get; set; }

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