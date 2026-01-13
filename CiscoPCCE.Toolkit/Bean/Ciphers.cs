using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Ciphers : BaseApiBean
    {
        [XmlElement("cipher")]
        public List<string?>? Cipherlist { get; set; }
    }
}