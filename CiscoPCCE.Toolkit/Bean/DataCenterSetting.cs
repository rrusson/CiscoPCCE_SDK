namespace CiscoPCCE.Toolkit.Bean
{
    public class DataCenterSetting : BaseApiBean
    {
        public required AgentDataCenterSetting Agent { get; set; }

        public string? BaseUrl { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required NetworkLabelGlobalSetting Labels { get; set; }
    }
}