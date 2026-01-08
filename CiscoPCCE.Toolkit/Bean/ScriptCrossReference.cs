using System.Xml.Serialization;

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