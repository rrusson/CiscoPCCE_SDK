using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("validationRule")]
public class SystemValidationRuleResult : BaseApiBean {
  private string? actual;
  private string? expected;
  private bool? isValid;
  private int? max;
  private int? min;
  private string? name;

  [XmlElement("actual")]
  public string? Actual
  {
      get => actual;
      set => actual = value;
  }


  public void setActual(String actual) {
     this.actual = actual;
  }

  [XmlElement("expected")]
  public string? Expected
  {
      get => expected;
      set => expected = value;
  }


  public void setExpected(String expected) {
     this.expected = expected;
  }

  [XmlElement("isValid")]
  public bool? IsValid
  {
      get => isValid;
      set => isValid = value;
  }


  public void setIsValid(Boolean isValid) {
     this.isValid = isValid;
  }

  [XmlElement("max")]
  public int? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(int? max) {
     this.max = max;
  }

  [XmlElement("min")]
  public int? Min
  {
      get => min;
      set => min = value;
  }


  public void setMin(int? min) {
     this.min = min;
  }

  [XmlElement("name")]
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