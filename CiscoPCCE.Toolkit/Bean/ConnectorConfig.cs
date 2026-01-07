using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class ConnectorConfig : BaseApiBean {
  private bool? proxyEnabled;
  private string? proxyHost;
  private string? proxyPort;

  public bool? ProxyEnabled
  {
      get => proxyEnabled;
      set => proxyEnabled = value;
  }


  public void setProxyEnabled(bool? proxyEnabled) {
     this.proxyEnabled = proxyEnabled;
  }

  public string? ProxyHost
  {
      get => proxyHost;
      set => proxyHost = value;
  }


  public void setProxyHost(String proxyHost) {
     this.proxyHost = proxyHost;
  }

  public string? ProxyPort
  {
      get => proxyPort;
      set => proxyPort = value;
  }


  public void setProxyPort(String proxyPort) {
     this.proxyPort = proxyPort;
  }


}

}