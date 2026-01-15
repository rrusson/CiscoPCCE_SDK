using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class NameUriPair : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

    }
}