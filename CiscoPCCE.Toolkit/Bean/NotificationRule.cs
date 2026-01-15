using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("NotificationRule")]
    public class NotificationRule : BaseApiBean
    {
        [XmlElement("campaignUrl")]
        public string? CampaignUrl { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlArray("tags")]
        [XmlArrayItem("tag")]
        public List<string?>? Tags { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}