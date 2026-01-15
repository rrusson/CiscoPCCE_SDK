using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("Campaign")]
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

    }
}