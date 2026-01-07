using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Ciphers : BaseApiBean
    {
        [XmlElement("cipher")]
        public List<string?>? Cipherlist { get; set; }
    }
}