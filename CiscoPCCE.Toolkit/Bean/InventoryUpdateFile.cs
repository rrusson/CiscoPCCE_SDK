using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("inventoryUpdateFile")]
public class InventoryUpdateFile : BaseApiBean {
  private InventoryUpdateCategory category;
  private string? content;
  private string? datacenter;
  private string? name;
  private InventoryUpdateOperation operation;
  private string? peripheralSetName;

  public InventoryUpdateCategory Category
  {
      get => category;
      set => category = value;
  }


  public void setCategory(InventoryUpdateCategory category) {
     this.category = category;
  }

  public string? Content
  {
      get => content;
      set => content = value;
  }


  public void setContent(String content) {
     this.content = content;
  }

  public string? Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(String datacenter) {
     this.datacenter = datacenter;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public InventoryUpdateOperation Operation
  {
      get => operation;
      set => operation = value;
  }


  public void setOperation(InventoryUpdateOperation operation) {
     this.operation = operation;
  }

  public string? PeripheralSetName
  {
      get => peripheralSetName;
      set => peripheralSetName = value;
  }


  public void setPeripheralSetName(String peripheralSetName) {
     this.peripheralSetName = peripheralSetName;
  }


}

}