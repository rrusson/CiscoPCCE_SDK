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

  public string? CmsUrl
  {
      get => cmsUrl;
      set => cmsUrl = value;
  }

  public string? ExpiresIn
  {
      get => expiresIn;
      set => expiresIn = value;
  }

  public string? OrgId
  {
      get => orgId;
      set => orgId = value;
  }

  public string? U2cHost
  {
      get => u2cHost;
      set => u2cHost = value;
  }

  // Path("contactcenterai/token")
  [XmlRoot("results")]
  public class ContactCenterAITokenList : BaseApiListBean<ContactCenterAIToken> {    public override List<ContactCenterAIToken>? GetItems() => items;

    public override void SetItems(List<ContactCenterAIToken>? value) => items = value;

  }
}

}