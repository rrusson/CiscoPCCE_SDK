using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("OrgSettings")]
public class OrgSettingsBean : BaseApiBean {
  private string? accessToken;
  private string? idBrokerHost;
  private string? idHost;
  private string? orgID;

  public string? AccessToken
  {
      get => accessToken;
      set => accessToken = value;
  }


  public void setAccessToken(String accessToken) {
     this.accessToken = accessToken;
  }

  public string? IdBrokerHost
  {
      get => idBrokerHost;
      set => idBrokerHost = value;
  }


  public void setIdBrokerHost(String idBrokerHost) {
     this.idBrokerHost = idBrokerHost;
  }

  public string? IdHost
  {
      get => idHost;
      set => idHost = value;
  }


  public void setIdHost(String idHost) {
     this.idHost = idHost;
  }

  public string? OrgID
  {
      get => orgID;
      set => orgID = value;
  }


  public void setOrgID(String orgID) {
     this.orgID = orgID;
  }


}

}