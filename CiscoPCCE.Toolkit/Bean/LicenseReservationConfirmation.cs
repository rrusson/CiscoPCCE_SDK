using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("licenseReservation")]
public class LicenseReservationConfirmation : BaseApiBean {
    
  public string? ConfirmationCode { get; set; }

  public string? InstallReservationType { get; set; }

}

}