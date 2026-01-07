using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("about")]
    public class ECEAbout : BaseApiBean
    {
        public string? Contact { get; set; }

        public string? Copyrights { get; set; }

        [XmlElement("products")]
        [XmlElement("product")]
        public List<ECEProduct>? Products { get; set; }

        public string? Trademarks { get; set; }
    }
}