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


  public void setGlobalConfigs(List<GlobalConfig> globalConfigs) {
     this.globalConfigs = globalConfigs;
  }

  public DateTime? LastSyncTime
  {
      get => lastSyncTime;
      set => lastSyncTime = value;
  }


  public void setLastSyncTime(Date lastSyncTime) {
     this.lastSyncTime = lastSyncTime;
  }

  public DateTime? NextAutoSyncTime
  {
      get => nextAutoSyncTime;
      set => nextAutoSyncTime = value;
  }


  public void setNextAutoSyncTime(Date nextAutoSyncTime) {
     this.nextAutoSyncTime = nextAutoSyncTime;
  }

  public Status Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(Status status) {
     this.status = status;
  }


  // Path("contactcenterai")
  [XmlRoot("results")]
  public class GlobalConfigDetailList : BaseApiListBean<GlobalConfigDetail> {
    [XmlElement("globalConfigDetails")]
    [XmlElement("globalConfigDetail")]
   
    public override List<GlobalConfigDetail>? GetItems() => items;

    public override void SetItems(List<GlobalConfigDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<GlobalConfigDetail>? items)
    {
        this.items = items;
    }
  }
}

}