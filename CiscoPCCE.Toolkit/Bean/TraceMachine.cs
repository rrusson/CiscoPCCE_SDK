using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class TraceMachine : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("traceProcesses")]
        [XmlArrayItem("traceProcess")]
        public List<TraceProcess>? TraceProcesses { get; set; }
    }
}