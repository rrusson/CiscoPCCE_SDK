using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class FileRef : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}