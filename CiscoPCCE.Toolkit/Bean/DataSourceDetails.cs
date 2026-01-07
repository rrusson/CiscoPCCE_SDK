namespace CiscoPCCE.Toolkit.Bean
{
    public class DataSourceDetails : BaseApiBean
    {
        public required DataSourceAddressRef Address { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Password { get; set; }

        public new string? RefURL { get; set; }

        public string? UserName { get; set; }
    }
}