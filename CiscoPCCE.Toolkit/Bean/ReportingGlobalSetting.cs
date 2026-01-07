using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("globalsetting")
[XmlRoot("reporting")]
public class ReportingGlobalSetting : BaseApiBean {
  private int? reportingInterval;

  public int? ReportingInterval
  {
      get => reportingInterval;
      set => reportingInterval = value;
  }


  public void setReportingInterval(int? reportingInterval) {
     this.reportingInterval = reportingInterval;
  }


  // Path("globalsetting")
  [XmlRoot("results")]
  public class ReportingGlobalSettingList : BaseApiListBean<ReportingGlobalSetting> {
    [XmlElement("reportings")]
    [XmlElement("reporting")]
   
    public override List<ReportingGlobalSetting>? GetItems() => items;

    public override void SetItems(List<ReportingGlobalSetting>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ReportingGlobalSetting>? items)
    {
        this.items = items;
    }
  }
}

}