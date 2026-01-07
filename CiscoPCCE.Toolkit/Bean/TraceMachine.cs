using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class TraceMachine : BaseApiBean {
  private string? refURL;
  private List<TraceProcess>? traceProcesses;

  [XmlElement("refURL")]
  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("traceProcesses")]
  [XmlElement("traceProcess")]
  public List<TraceProcess>? TraceProcesses
  {
      get => traceProcesses;
      set => traceProcesses = value;
  }


  public void setTraceProcesses(List<TraceProcess> traceProcesses) {
     this.traceProcesses = traceProcesses;
  }


}

}