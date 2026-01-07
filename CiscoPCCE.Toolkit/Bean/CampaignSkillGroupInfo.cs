using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CampaignSkillGroupInfo : BaseApiBean
    {
        [XmlElement("abandonedRoutePoint")]
        public string? AbandonedRoutePoint { get; set; }

        [XmlElement("dialedNumber")]
        public string? DialedNumber { get; set; }

        [XmlElement("ivrPorts")]
        public int? IvrPorts { get; set; }

        [XmlElement("ivrRoutePoint")]
        public string? IvrRoutePoint { get; set; }

        [XmlElement("overflowAgents")]
        public int? OverflowAgents { get; set; }

        [XmlElement("recordsToCache")]
        public int? RecordsToCache { get; set; }

        [XmlElement("skillGroup")]
        public required ReferenceBean SkillGroupRef { get; set; }
    }
}