using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Feed")]
    public class Feed : BaseApiBean
    {
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
        public int? Type { get; set; }
    }
}