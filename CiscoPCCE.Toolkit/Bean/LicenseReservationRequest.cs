using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("licenseReservation")]
public class LicenseReservationRequest : BaseApiBean {
  private string? reservationCode;

  public string? ReservationCode
  {
      get => reservationCode;
      set => reservationCode = value;
  }


  public void setReservationCode(String reservationCode) {
     this.reservationCode = reservationCode;
  }


}

}