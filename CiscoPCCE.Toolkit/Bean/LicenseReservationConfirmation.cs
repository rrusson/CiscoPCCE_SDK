using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("licenseReservation")]
public class LicenseReservationConfirmation : BaseApiBean {
  private string? confirmationCode;
  private string? installReservationType;

  public string? ConfirmationCode
  {
      get => confirmationCode;
      set => confirmationCode = value;
  }


  public void setConfirmationCode(String confirmationCode) {
     this.confirmationCode = confirmationCode;
  }

  public string? InstallReservationType
  {
      get => installReservationType;
      set => installReservationType = value;
  }


  public void setInstallReservationType(String installReservationType) {
     this.installReservationType = installReservationType;
  }


}

}