using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("AgentPQCount")]
    public class AgentPQCount : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("pqCount")]
        public int? pqCount { get; set; }

        [XmlArray("pqNameList")]
        [XmlArrayItem("pqName")]
        public List<PQName>? pqNameList { get; set; }
    }
}