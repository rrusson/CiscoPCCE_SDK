using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class ValueErrorDetail : BaseApiBean {
  private string? value;

  public string? Value
  {
      get => value;
      set => value = value;
  }


  public void setValue(String value) {
     this.value = value;
  }


}

}