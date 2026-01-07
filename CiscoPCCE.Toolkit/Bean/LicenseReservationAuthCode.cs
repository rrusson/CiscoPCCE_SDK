using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("licenseReservation")]
public class LicenseReservationAuthCode : BaseApiBean {
  
  public string? AuthorizationCode { get; set; }

}

}