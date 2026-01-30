using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class FileRefWithSize : BaseApiBean
    {
        [XmlElement("size")]
        public long? Size { get; set; }
    }
}