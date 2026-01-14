using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("AgentPQCount")]
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