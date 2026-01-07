using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactcenterai/token")
[XmlRoot("contactCenterAIToken")]
public class ContactCenterAIToken : BaseApiBean {
  private string? accessToken;
  private string? cmsUrl;
  private string? expiresIn;
  private string? orgId;
  private string? u2cHost;

  public string? AccessToken
  {
      get => accessToken;
      set => accessToken = value;
  }


  public void setAccessToken(String accessToken) {
     this.accessToken = accessToken;
  }

  public string? CmsUrl
  {
      get => cmsUrl;
      set => cmsUrl = value;
  }


  public void setCmsUrl(String cmsUrl) {
     this.cmsUrl = cmsUrl;
  }

  public string? ExpiresIn
  {
      get => expiresIn;
      set => expiresIn = value;
  }


  public void setExpiresIn(String expiresIn) {
     this.expiresIn = expiresIn;
  }

  public string? OrgId
  {
      get => orgId;
      set => orgId = value;
  }


  public void setOrgId(String orgId) {
     this.orgId = orgId;
  }

  public string? U2cHost
  {
      get => u2cHost;
      set => u2cHost = value;
  }


  public void setU2cHost(String u2cHost) {
     this.u2cHost = u2cHost;
  }


  // Path("contactcenterai/token")
  [XmlRoot("results")]
  public class ContactCenterAITokenList : BaseApiListBean<ContactCenterAIToken> {
    [XmlElement("contactCenterAITokens")]
    [XmlElement("contactCenterAIToken")]
   
    public override List<ContactCenterAIToken>? GetItems() => items;

    public override void SetItems(List<ContactCenterAIToken>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactCenterAIToken>? items)
    {
        this.items = items;
    }
  }
}

}