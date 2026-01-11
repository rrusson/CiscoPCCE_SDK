using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ChangeSetElement : BaseApiBean
    {
        [XmlElement("beans")]
        public required BaseDbRestBean Beans { get; set; }
    }
}