using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("initialize")
[XmlRoot("initializationStatus")]
public class InitializationStatus : BaseApiBean {
  private List<ApiError>? apiErrors;
  private StateEnum state;
  private string? stateString;
  private string? taskName;

  [XmlElement("apiErrors")]
  [XmlElement("apiError")]
  public List<ApiError>? ApiErrors
  {
      get => apiErrors;
      set => apiErrors = value;
  }

  public StateEnum State
  {
      get => state;
      set => state = value;
  }

  public string? StateString
  {
      get => stateString;
      set => stateString = value;
  }

  [XmlElement("name")]
  public string? TaskName
  {
      get => taskName;
      set => taskName = value;
  }

  // Path("initialize")
  [XmlRoot("results")]
  public class InitializationStatusList : BaseApiListBean<InitializationStatus> {    public override List<InitializationStatus>? GetItems() => items;

    public override void SetItems(List<InitializationStatus>? value) => items = value;

  }
}

}