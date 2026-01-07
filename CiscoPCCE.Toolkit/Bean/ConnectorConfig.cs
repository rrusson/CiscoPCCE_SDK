using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class ConnectorConfig : BaseApiBean {
      
  public bool? ProxyEnabled { get; set; }

  public string? ProxyHost { get; set; }

  public string? ProxyPort { get; set; }

}

}