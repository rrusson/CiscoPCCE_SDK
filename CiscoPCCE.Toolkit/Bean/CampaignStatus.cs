using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("runtimeStatus")]
    public class CampaignStatus : BaseApiBean
    {
        public int? AbandonDetectCount { get; set; }

        [XmlElement("abandonToIvrCount")]
        public int? AbandonToIVRCount { get; set; }

        public int? AgentClosedCount { get; set; }

        public int? AgentRejectedCount { get; set; }

        public int? AnsweringMachineCount { get; set; }

        public int? AttemptedCount { get; set; }

        public int? BusyCount { get; set; }

        public int? CallBackCount { get; set; }

        public int? CancelledDetectCount { get; set; }

        public int? ClosedCount { get; set; }

        public int? CustomerAbandonDetectCount { get; set; }

        public int? CustomerNotHomeCount { get; set; }

        public DateTime? DateTime { get; set; }

        public int? FaxDetectCount { get; set; }

        public int? NetworkAnsMachineCount { get; set; }

        public int? NoAnswerDetectCount { get; set; }

        public int? NoDialToneDetectCount { get; set; }

        public int? NoRingBackDetectCount { get; set; }

        public int? PersonalCallbackCount { get; set; }

        public int? SitToneDetectCount { get; set; }

        public int? TalkTimeCount { get; set; }

        public int? TotalCount { get; set; }

        public int? TotalVoiceCount { get; set; }

        public int? VoiceCount { get; set; }

        public int? WrapupTimeCount { get; set; }

        public int? WrongNumberCount { get; set; }

        // Path("campaign")
        [XmlRoot("results")]
        public class CampaignStatusList : BaseApiListBean<CampaignStatus>
        {
            public override List<CampaignStatus>? GetItems() => Items;

            public override void SetItems(List<CampaignStatus>? value) => Items = value;
        }
    }
}