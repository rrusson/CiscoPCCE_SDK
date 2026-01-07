using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactcenterai")
[XmlRoot("globalConfigDetail")]
public class GlobalConfigDetail : BaseApiBean {
  private List<GlobalConfig>? globalConfigs;
  private DateTime? lastSyncTime;
  private DateTime? nextAutoSyncTime;
  private Status status;

  [XmlElement("globalConfigs")]
  [XmlElement("globalConfig")]
  public List<GlobalConfig>? GlobalConfigs
  {
      get => globalConfigs;
      set => globalConfigs = value;
  }

  public DateTime? LastSyncTime
  {
      get => lastSyncTime;
      set => lastSyncTime = value;
  }

  public DateTime? NextAutoSyncTime
  {
      get => nextAutoSyncTime;
      set => nextAutoSyncTime = value;
  }

  public Status Status
  {
      get => status;
      set => status = value;
  }

  // Path("contactcenterai")
  [XmlRoot("results")]
  public class GlobalConfigDetailList : BaseApiListBean<GlobalConfigDetail> {    public override List<GlobalConfigDetail>? GetItems() => items;

    public override void SetItems(List<GlobalConfigDetail>? value) => items = value;

  }
}

}