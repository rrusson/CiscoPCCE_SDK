using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("campaign")]
    public class Campaign : BaseApiBean
    {
        public bool? AbandonEnabled { get; set; }

        public float? AbandonPercent { get; set; }

        public AmdTreatmentModeEnum AmdTreatmentMode { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("campaignPrefix")]
        public string? CampaignPrefix { get; set; }

        public CampaignPurposeTypeEnum CampaignPurposeType { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        [XmlElement("callProgressAnalysis")]
        public required CampaignCPAFields CpaFields { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public DialingMode DialingMode { get; set; }

        public bool? Enabled { get; set; }

        public DateTime? EndDate { get; set; }

        public string? EndTime { get; set; }

        public string? IdFromRefUrl { get; set; }

        [XmlElement("import")]
        public required ImportContact ImportContact { get; set; }

        public bool? IpAmdEnabled { get; set; }

        public bool? IpTerminatingBeepDetect { get; set; }

        public float? LinesPerAgent { get; set; }

        public bool? MarkDeletable { get; set; }

        public int? MaxAttempts { get; set; }

        public float? MaximumLinesPerAgent { get; set; }

        public int? MinimumCallDuration { get; set; }

        public string? Name { get; set; }

        public int? NoAnswerRingLimit { get; set; }

        public bool? PersonalizedCallbackEnabled { get; set; }

        public int? PredictiveCorrectionPace { get; set; }

        public float? PredictiveGain { get; set; }

        public new string? RefURL { get; set; }

        public RescheduleCallbackModeEnum RescheduleCallbackMode { get; set; }

        public int? ReservationPercentage { get; set; }

        public required CampaignRetryFields Retries { get; set; }

        [XmlElement("skillGroupInfos")]
        [XmlElement("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfos { get; set; }

        [XmlElement("skillGroupInfosAdded")]
        [XmlElement("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfosAdded { get; set; }

        [XmlElement("skillGroupInfosRemoved")]
        [XmlElement("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfosRemoved { get; set; }

        public DateTime? StartDate { get; set; }

        public string? StartTime { get; set; }

        public required TimeZoneRef TimeZone { get; set; }

        // Path("campaign")
        [XmlRoot("results")]
        public class CampaignList : BaseApiListBean<Campaign>
        {
            public override List<Campaign>? GetItems() => Items;

            public override void SetItems(List<Campaign>? value) => Items = value;
        }
    }
}