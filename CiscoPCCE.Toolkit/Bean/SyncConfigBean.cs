using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("syncConfig")]
public class SyncConfigBean : BaseApiBean {
  private bool? enabled;
  private string? endTime;
  private int? frequency;
  private List<string?>? groups;
  private string? startTime;

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(Boolean enabled) {
     this.enabled = enabled;
  }

  public string? EndTime
  {
      get => endTime;
      set => endTime = value;
  }


  public void setEndTime(String endTime) {
     this.endTime = endTime;
  }

  public int? Frequency
  {
      get => frequency;
      set => frequency = value;
  }


  public void setFrequency(int? frequency) {
     this.frequency = frequency;
  }

  [XmlElement("groups")]
  [XmlElement("group")]
  public List<string?>? Groups
  {
      get => groups;
      set => groups = value;
  }


  public void setGroups(List<String> groups) {
     this.groups = groups;
  }

  public string? StartTime
  {
      get => startTime;
      set => startTime = value;
  }


  public void setStartTime(String startTime) {
     this.startTime = startTime;
  }


}

}