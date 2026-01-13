using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SkillGroupWithPqId : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }
    }
}