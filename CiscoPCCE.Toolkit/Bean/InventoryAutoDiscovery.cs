using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("systemmgmt")
[XmlRoot("inventoryautodiscovery")]
public class InventoryAutoDiscovery : BaseApiBean {
  private bool? disabled;

  public bool? Disabled
  {
      get => disabled;
      set => disabled = value;
  }


  public void setDisabled(bool? disabled) {
     this.disabled = disabled;
  }


  // Path("systemmgmt")
  [XmlRoot("results")]
  public class InventoryAutoDiscoveryList : BaseApiListBean<InventoryAutoDiscovery> {
    [XmlElement("inventoryautodiscoverys")]
    [XmlElement("inventoryautodiscovery")]
   
    public override List<InventoryAutoDiscovery>? GetItems() => items;

    public override void SetItems(List<InventoryAutoDiscovery>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InventoryAutoDiscovery>? items)
    {
        this.items = items;
    }
  }
}

}