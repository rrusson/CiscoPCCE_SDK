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


  public void setAlerts(List<Alert> alerts) {
     this.alerts = alerts;
  }

  public ScanInfo ScanInfo
  {
      get => scanInfo;
      set => scanInfo = value;
  }


  public void setScanInfo(ScanInfo scanInfo) {
     this.scanInfo = scanInfo;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class InventoryStatusList : BaseApiListBean<InventoryStatus> {
    [XmlElement("statuss")]
    [XmlElement("status")]
   
    public override List<InventoryStatus>? GetItems() => items;

    public override void SetItems(List<InventoryStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InventoryStatus>? items)
    {
        this.items = items;
    }
  }
}

}