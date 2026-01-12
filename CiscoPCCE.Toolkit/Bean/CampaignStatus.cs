using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("campaign")
    [XmlRoot("runtimeStatus")]
    public class CampaignStatus : BaseApiBean
    {
        [XmlElement("abandonDetectCount")]
        public int? AbandonDetectCount { get; set; }

        [XmlElement("abandonToIvrCount")]
        public int? AbandonToIVRCount { get; set; }

        [XmlElement("agentClosedCount")]
        public int? AgentClosedCount { get; set; }

        [XmlElement("agentRejectedCount")]
        public int? AgentRejectedCount { get; set; }

        [XmlElement("answeringMachineCount")]
        public int? AnsweringMachineCount { get; set; }

        [XmlElement("attemptedCount")]
        public int? AttemptedCount { get; set; }

        [XmlElement("busyCount")]
        public int? BusyCount { get; set; }

        [XmlElement("callBackCount")]
        public int? CallBackCount { get; set; }

        [XmlElement("cancelledDetectCount")]
        public int? CancelledDetectCount { get; set; }

        [XmlElement("closedCount")]
        public int? ClosedCount { get; set; }

        [XmlElement("customerAbandonDetectCount")]
        public int? CustomerAbandonDetectCount { get; set; }

        [XmlElement("customerNotHomeCount")]
        public int? CustomerNotHomeCount { get; set; }

        [XmlElement("dateTime")]
        public DateTime? DateTime { get; set; }

        [XmlElement("faxDetectCount")]
        public int? FaxDetectCount { get; set; }

        [XmlElement("networkAnsMachineCount")]
        public int? NetworkAnsMachineCount { get; set; }

        [XmlElement("noAnswerDetectCount")]
        public int? NoAnswerDetectCount { get; set; }

        [XmlElement("noDialToneDetectCount")]
        public int? NoDialToneDetectCount { get; set; }

        [XmlElement("noRingBackDetectCount")]
        public int? NoRingBackDetectCount { get; set; }

        [XmlElement("personalCallbackCount")]
        public int? PersonalCallbackCount { get; set; }

        [XmlElement("sitToneDetectCount")]
        public int? SitToneDetectCount { get; set; }

        [XmlElement("talkTimeCount")]
        public int? TalkTimeCount { get; set; }

        [XmlElement("totalCount")]
        public int? TotalCount { get; set; }

        [XmlElement("totalVoiceCount")]
        public int? TotalVoiceCount { get; set; }

        [XmlElement("voiceCount")]
        public int? VoiceCount { get; set; }

        [XmlElement("wrapupTimeCount")]
        public int? WrapupTimeCount { get; set; }

        [XmlElement("wrongNumberCount")]
        public int? WrongNumberCount { get; set; }
        
    }
}