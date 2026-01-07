using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("inventoryFile")]
public class InventoryFile : BaseApiBean {
  private string? content;
  private string? name;

  public string? Content
  {
      get => content;
      set => content = value;
  }


  public void setContent(String content) {
     this.content = content;
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