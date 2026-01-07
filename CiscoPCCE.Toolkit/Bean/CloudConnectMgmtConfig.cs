using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CloudConnectMgmtConfig : BaseApiBean {
  private ConnectorConfig connCfg;
  private long? lastUpdatedTimestamp;

  public ConnectorConfig ConnCfg
  {
      get => connCfg;
      set => connCfg = value;
  }


  public void setConnCfg(ConnectorConfig connCfg) {
     this.connCfg = connCfg;
  }

  public long? LastUpdatedTimestamp
  {
      get => lastUpdatedTimestamp;
      set => lastUpdatedTimestamp = value;
  }


  public void setLastUpdatedTimestamp(long? lastUpdatedTimestamp) {
     this.lastUpdatedTimestamp = lastUpdatedTimestamp;
  }


}

}