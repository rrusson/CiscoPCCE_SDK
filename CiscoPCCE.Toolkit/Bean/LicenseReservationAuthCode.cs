using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("licenseReservation")]
public class LicenseReservationAuthCode : BaseApiBean {
  private string? authorizationCode;

  public string? AuthorizationCode
  {
      get => authorizationCode;
      set => authorizationCode = value;
  }


  public void setAuthorizationCode(String authorizationCode) {
     this.authorizationCode = authorizationCode;
  }


}

}