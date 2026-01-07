using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("machineinventory")
[XmlRoot("status")]
public class InventoryStatus : BaseApiBean {
  private List<Alert>? alerts;
  private ScanInfo scanInfo;

  [XmlElement("alerts")]
  [XmlElement("alert")]
  public List<Alert>? Alerts
  {
      get => alerts;
      set => alerts = value;
  }

  public ScanInfo ScanInfo
  {
      get => scanInfo;
      set => scanInfo = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class InventoryStatusList : BaseApiListBean<InventoryStatus> {    public override List<InventoryStatus>? GetItems() => items;

    public override void SetItems(List<InventoryStatus>? value) => items = value;

  }
}

}