using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("asrServer")]
public class AsrServer : BaseApiBean {
  private int? asrServerId;
  private string? asrServerName;
  private Locales locales;
  private int portNumber;
  private string? providerName;
  private string? self;
  private string? status;

  public int? AsrServerId
  {
      get => asrServerId;
      set => asrServerId = value;
  }


  public void setAsrServerId(int? asrServerId) {
     this.asrServerId = asrServerId;
  }

  public string? AsrServerName
  {
      get => asrServerName;
      set => asrServerName = value;
  }


  public void setAsrServerName(String asrServerName) {
     this.asrServerName = asrServerName;
  }

  public Locales Locales
  {
      get => locales;
      set => locales = value;
  }


  public void setLocales(Locales locales) {
     this.locales = locales;
  }

  public int PortNumber
  {
      get => portNumber;
      set => portNumber = value;
  }


  public void setPortNumber(int portNumber) {
     this.portNumber = portNumber;
  }

  public string? ProviderName
  {
      get => providerName;
      set => providerName = value;
  }


  public void setProviderName(String providerName) {
     this.providerName = providerName;
  }

  public string? Self
  {
      get => self;
      set => self = value;
  }


  public void setSelf(String self) {
     this.self = self;
  }

  public string? Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(String status) {
     this.status = status;
  }


}

}