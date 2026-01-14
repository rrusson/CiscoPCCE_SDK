using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("about")]
    public class ECEAbout : BaseApiBean
    {
        [XmlElement("contact")]
        public string? Contact { get; set; }

        [XmlElement("copyrights")]
        public string? Copyrights { get; set; }

        [XmlArray("products")]
        [XmlArrayItem("product")]
        public List<ECEProduct>? Products { get; set; }

        [XmlElement("trademarks")]
        public string? Trademarks { get; set; }
    }
}