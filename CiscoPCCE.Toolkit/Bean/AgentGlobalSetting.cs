namespace CiscoPCCE.Toolkit.Bean
{
    public class AgentGlobalSetting : BaseApiBean
    {
        public int? AgentPhoneLineControl { get; set; }

        public string? BaseUrl { get; set; }

        public required ReferenceBean DefaultDeskSetting { get; set; }

        public bool? LoginNameCaseSensitivity { get; set; }

        public int? MinimumPasswordLength { get; set; }

        public int? NonACDLineImpact { get; set; }
    }
}