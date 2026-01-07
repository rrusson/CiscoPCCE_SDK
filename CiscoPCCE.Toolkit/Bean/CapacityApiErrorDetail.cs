using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class CapacityApiErrorDetail : BaseApiBean {
  private int? actual;
  private int? max;
  private string? name;

  public int? Actual
  {
      get => actual;
      set => actual = value;
  }


  public void setActual(int? actual) {
     this.actual = actual;
  }

  public int? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(int? max) {
     this.max = max;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


}

}