using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CampaignRetryFields : BaseApiBean
    {
        [XmlElement("answeringMachineDelay")]
        public int? AnsweringMachineDelay { get; set; }

        [XmlElement("busySignalDelay")]
        public int? BusySignalDelay { get; set; }

        [XmlElement("customerAbandonedDelay")]
        public int? CustomerAbandonedDelay { get; set; }

        [XmlElement("customerNotHomeDelay")]
        public int? CustomerNotHomeDelay { get; set; }

        [XmlElement("dialerAbandonedDelay")]
        public int? DialerAbandonedDelay { get; set; }

        [XmlElement("noAnswerDelay")]
        public int? NoAnswerDelay { get; set; }
    }
}