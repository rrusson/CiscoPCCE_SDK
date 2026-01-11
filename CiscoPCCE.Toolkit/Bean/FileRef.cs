using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class FileRef : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}