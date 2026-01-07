using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("datacenter")]
public class DataCenterInventoryFile : BaseApiBean {
  private InventoryFile inventoryFile;
  private string? name;

  public InventoryFile InventoryFile
  {
      get => inventoryFile;
      set => inventoryFile = value;
  }


  public void setInventoryFile(InventoryFile inventoryFile) {
     this.inventoryFile = inventoryFile;
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