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

  public string? InstanceName
  {
      get => instanceName;
      set => instanceName = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("instance")
  [XmlRoot("results")]
  public class WebsetupInstanceList : BaseApiListBean<WebsetupInstance> {    public override List<WebsetupInstance>? GetItems() => items;

    public override void SetItems(List<WebsetupInstance>? value) => items = value;

  }
}

}