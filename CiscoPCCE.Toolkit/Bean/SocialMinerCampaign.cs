using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Campaign")]
    public class SocialMinerCampaign : BaseApiBean
    {
        public new int? ChangeStamp { get; set; }

        public string? Description { get; set; }

        [XmlElement("feeds")]
        [XmlElement("feed")]
        public List<string?>? Feeds { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }
    }
}