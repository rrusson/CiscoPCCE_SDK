using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class SystemValidationApiErrorDetail : BaseApiBean {
  private string? actual;
  private string? expected;
  private int? max;
  private int? min;
  private string? name;

  public string? Actual
  {
      get => actual;
      set => actual = value;
  }


  public void setActual(String actual) {
     this.actual = actual;
  }

  public string? Expected
  {
      get => expected;
      set => expected = value;
  }


  public void setExpected(String expected) {
     this.expected = expected;
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