using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Campaign")]
    public class SocialMinerCampaign : BaseApiBean
    {
        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlArray("feeds")]
        [XmlArrayItem("feed")]
        public List<string?>? Feeds { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}