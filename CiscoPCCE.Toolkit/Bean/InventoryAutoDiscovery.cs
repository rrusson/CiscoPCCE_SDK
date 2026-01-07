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

  // Path("systemmgmt")
  [XmlRoot("results")]
  public class InventoryAutoDiscoveryList : BaseApiListBean<InventoryAutoDiscovery> {    public override List<InventoryAutoDiscovery>? GetItems() => items;

    public override void SetItems(List<InventoryAutoDiscovery>? value) => items = value;

  }
}

}