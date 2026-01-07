namespace CiscoPCCE.Toolkit.Bean
{
    public class BaseDbRestBean : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }
    }
}