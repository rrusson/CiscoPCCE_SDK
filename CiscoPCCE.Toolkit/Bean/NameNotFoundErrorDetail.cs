using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class NameNotFoundErrorDetail : BaseApiBean {
  private string? name;
  private string? type;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }


}

}