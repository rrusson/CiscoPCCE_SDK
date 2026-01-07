namespace CiscoPCCE.Toolkit.Bean
{
    // Path("globalsetting")
    public class LabelBase : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required ReferenceBean NetworkTarget { get; set; }

        public new string? RefURL { get; set; }
    }
}