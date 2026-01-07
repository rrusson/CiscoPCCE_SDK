using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class CloudConnectMgmtConfig : BaseApiBean {
    
  public ConnectorConfig ConnCfg { get; set; }

  public long? LastUpdatedTimestamp { get; set; }

}

}