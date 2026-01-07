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

  // Path("globalsetting")
  [XmlRoot("results")]
  public class ReportingGlobalSettingList : BaseApiListBean<ReportingGlobalSetting> {    public override List<ReportingGlobalSetting>? GetItems() => items;

    public override void SetItems(List<ReportingGlobalSetting>? value) => items = value;

  }
}

}