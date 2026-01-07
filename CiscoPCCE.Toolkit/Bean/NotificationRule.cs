using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("NotificationRule")]
    public class NotificationRule : BaseApiBean
    {
        public string? CampaignUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? Description { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("tags")]
        [XmlElement("tag")]
        public List<string?>? Tags { get; set; }

        public string? Type { get; set; }
    }
}