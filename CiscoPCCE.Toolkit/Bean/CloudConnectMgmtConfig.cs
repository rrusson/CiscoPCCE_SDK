namespace CiscoPCCE.Toolkit.Bean
{
    public class CloudConnectMgmtConfig : BaseApiBean
    {
        public required ConnectorConfig ConnCfg { get; set; }

        public long? LastUpdatedTimestamp { get; set; }
    }
}