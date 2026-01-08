using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SkillGroupWithPqId : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }
    }
}