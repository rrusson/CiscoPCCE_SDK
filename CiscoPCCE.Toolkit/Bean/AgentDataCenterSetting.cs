namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentDataCenterSetting : BaseApiBean
    {
        public int? AgentPhoneLineControl { get; set; }

        public string? BaseUrl { get; set; }

        public required ReferenceBean DefaultDeskSetting { get; set; }

        public int? NonACDLineImpact { get; set; }
    }
}