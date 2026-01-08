using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("campaign")]
    public class Campaign : BaseApiBean
    {
        [XmlElement("abandonEnabled")]
        public bool? AbandonEnabled { get; set; }

        [XmlElement("abandonPercent")]
        public float? AbandonPercent { get; set; }

        [XmlElement("amdTreatmentMode")]
        public AmdTreatmentModeEnum AmdTreatmentMode { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("campaignPrefix")]
        public string? CampaignPrefix { get; set; }

        [XmlElement("campaignPurposeType")]
        public CampaignPurposeTypeEnum CampaignPurposeType { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("callProgressAnalysis")]
        public required CampaignCPAFields CpaFields { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("dialingMode")]
        public DialingMode DialingMode { get; set; }

        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        [XmlElement("endDate")]
        public DateTime? EndDate { get; set; }

        [XmlElement("endTime")]
        public string? EndTime { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("import")]
        public required ImportContact ImportContact { get; set; }

        [XmlElement("ipAmdEnabled")]
        public bool? IpAmdEnabled { get; set; }

        [XmlElement("ipTerminatingBeepDetect")]
        public bool? IpTerminatingBeepDetect { get; set; }

        [XmlElement("linesPerAgent")]
        public float? LinesPerAgent { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("maxAttempts")]
        public int? MaxAttempts { get; set; }

        [XmlElement("maximumLinesPerAgent")]
        public float? MaximumLinesPerAgent { get; set; }

        [XmlElement("minimumCallDuration")]
        public int? MinimumCallDuration { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("noAnswerRingLimit")]
        public int? NoAnswerRingLimit { get; set; }

        [XmlElement("personalizedCallbackEnabled")]
        public bool? PersonalizedCallbackEnabled { get; set; }

        [XmlElement("predictiveCorrectionPace")]
        public int? PredictiveCorrectionPace { get; set; }

        [XmlElement("predictiveGain")]
        public float? PredictiveGain { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("rescheduleCallbackMode")]
        public RescheduleCallbackModeEnum RescheduleCallbackMode { get; set; }

        [XmlElement("reservationPercentage")]
        public int? ReservationPercentage { get; set; }

        [XmlElement("retries")]
        public required CampaignRetryFields Retries { get; set; }

        [XmlArray("skillGroupInfos")]
        [XmlArrayItem("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfos { get; set; }

        [XmlArray("skillGroupInfosAdded")]
        [XmlArrayItem("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfosAdded { get; set; }

        [XmlArray("skillGroupInfosRemoved")]
        [XmlArrayItem("skillGroupInfo")]
        public List<CampaignSkillGroupInfo>? SkillGroupInfosRemoved { get; set; }

        [XmlElement("startDate")]
        public DateTime? StartDate { get; set; }

        [XmlElement("startTime")]
        public string? StartTime { get; set; }

        [XmlElement("timeZone")]
        public required TimeZoneRef TimeZone { get; set; }

        // Path("campaign")
        [XmlRoot("results")]
        public class CampaignList : BaseApiListBean<Campaign>
        {
            [XmlArray("campaigns")]
            [XmlArrayItem("campaign")]
            public new List<Campaign>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Campaign>? GetItems() => Items;

            public override void SetItems(List<Campaign>? value) => Items = value;
        }
    }
}