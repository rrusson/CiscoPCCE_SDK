using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("inventoryUpdateFile")]
public class InventoryUpdateFile : BaseApiBean {
            
  public InventoryUpdateCategory Category { get; set; }

  public string? Content { get; set; }

  public string? Datacenter { get; set; }

  public string? Name { get; set; }

  public InventoryUpdateOperation Operation { get; set; }

  public string? PeripheralSetName { get; set; }

}

}