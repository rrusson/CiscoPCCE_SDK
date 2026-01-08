using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("NotificationRule")]
    public class NotificationRule : BaseApiBean
    {
        [XmlElement("campaignUrl")]
        public string? CampaignUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("tags")]
        [XmlArrayItem("tag")]
        public List<string?>? Tags { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}