using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("instance")
[XmlRoot("instance")]
public class WebsetupInstance : BaseApiBean {
  private string? facilityName;
  private string? instanceName;
  private string? refURL;

  public string? FacilityName
  {
      get => facilityName;
      set => facilityName = value;
  }


  public void setFacilityName(String facilityName) {
     this.facilityName = facilityName;
  }

  public string? InstanceName
  {
      get => instanceName;
      set => instanceName = value;
  }


  public void setInstanceName(String instanceName) {
     this.instanceName = instanceName;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("instance")
  [XmlRoot("results")]
  public class WebsetupInstanceList : BaseApiListBean<WebsetupInstance> {
    [XmlElement("instances")]
    [XmlElement("instance")]
   
    public override List<WebsetupInstance>? GetItems() => items;

    public override void SetItems(List<WebsetupInstance>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<WebsetupInstance>? items)
    {
        this.items = items;
    }
  }
}

}