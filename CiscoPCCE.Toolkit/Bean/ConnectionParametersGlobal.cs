using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class ConnectionParametersGlobal : BaseApiBean {
        
  public HeartBeat HeartBeat { get; set; }

  public int? MaxErrors { get; set; }

  public Session Session { get; set; }

  public Timeout Timeout { get; set; }

}

}