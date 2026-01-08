using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ChangeSetElement : BaseApiBean
    {
        [XmlElement("beans")]
        public required BaseDbRestBean Beans { get; set; }
    }
}