using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class SipServerElementErrorDetail : BaseApiBean {
  private string? address;
  private string? field;
  private int? max;
  private int? min;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public string? Field
  {
      get => field;
      set => field = value;
  }


  public void setField(String field) {
     this.field = field;
  }

  public int? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(int? max) {
     this.max = max;
  }

  public int? Min
  {
      get => min;
      set => min = value;
  }


  public void setMin(int? min) {
     this.min = min;
  }


}

}