using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("property")]
public class Property : BaseApiBean {
  private string? name;
  private string? value;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

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