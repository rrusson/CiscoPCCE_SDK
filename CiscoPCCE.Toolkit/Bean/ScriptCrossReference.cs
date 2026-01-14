using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ScriptCrossReference : BaseApiBean
    {
        [XmlElement("foreignKey")]
        public int? ForeignKey { get; set; }

        [XmlElement("targetType")]
        public int? TargetType { get; set; }
    }
}