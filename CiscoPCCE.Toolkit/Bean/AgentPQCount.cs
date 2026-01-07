using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("AgentPQCount")]
    public class AgentPQCount : BaseApiBean
    {
        public new string? RefURL { get; set; }

        public int? pqCount { get; set; }

        [XmlElement("pqNameList")]
        [XmlElement("pqName")]
        public List<PQName>? pqNameList { get; set; }
    }
}