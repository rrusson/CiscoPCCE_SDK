using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("licenseReservation")]
public class LicenseReservationReturnCode : BaseApiBean {
  private string? returnReservationCode;

  public string? ReturnReservationCode
  {
      get => returnReservationCode;
      set => returnReservationCode = value;
  }


  public void setReturnReservationCode(String returnReservationCode) {
     this.returnReservationCode = returnReservationCode;
  }


}

}