using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class TraceMachine : BaseApiBean
    {
        [XmlArray("traceProcesses")]
        [XmlArrayItem("traceProcess")]
        public List<TraceProcess>? TraceProcesses { get; set; }
    }
}