using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class TraceMachine : BaseApiBean
    {
        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("traceProcesses")]
        [XmlElement("traceProcess")]
        public List<TraceProcess>? TraceProcesses { get; set; }
    }
}