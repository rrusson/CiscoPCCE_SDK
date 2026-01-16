using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CardPosition : BaseApiBean
    {
        [XmlElement("position")]
        public int Position { get; set; }

    }
}