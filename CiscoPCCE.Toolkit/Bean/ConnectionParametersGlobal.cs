namespace CiscoPCCE.Toolkit.Bean
{
    public class ConnectionParametersGlobal : BaseApiBean
    {
        public required HeartBeat HeartBeat { get; set; }

        public int? MaxErrors { get; set; }

        public required Session Session { get; set; }

        public required Timeout Timeout { get; set; }
    }
}