using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class TraceMachine : BaseApiBean {
    
  [XmlElement("refURL")]
  public string? RefURL { get; set; }

  [XmlElement("traceProcesses")]
  [XmlElement("traceProcess")]
  public List<TraceProcess>? TraceProcesses { get; set; }

}

}