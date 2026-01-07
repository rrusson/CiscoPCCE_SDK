namespace CiscoPCCE.Toolkit.Bean
{
    public class ApplicationGatewayConnection : BaseApiBean
    {
        public string? Address { get; set; }

        public required HeartBeat HeartBeat { get; set; }

        public bool? InService { get; set; }

        public string? InitializationData { get; set; }

        public int? MaxErrors { get; set; }

        public int? Port { get; set; }

        public required Session Session { get; set; }

        public ApplicationGatewayPreferredSide Side { get; set; }

        public required Timeout Timeout { get; set; }
    }
}