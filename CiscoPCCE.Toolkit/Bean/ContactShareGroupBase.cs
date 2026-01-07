namespace CiscoPCCE.Toolkit.Bean
{
    // Path("contactsharegroup")
    public class ContactShareGroupBase : BaseApiBean
    {
        public string? AcceptQueueIf { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public required ReferenceBean ContactShareRule { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public int? QueueCount { get; set; }

        public new string? RefURL { get; set; }
    }
}