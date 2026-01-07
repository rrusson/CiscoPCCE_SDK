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


  public void setApiErrors(List<ApiError> apiErrors) {
     this.apiErrors = apiErrors;
  }

  public StateEnum State
  {
      get => state;
      set => state = value;
  }


  public void setState(StateEnum state) {
     this.state = state;
  }

  public string? StateString
  {
      get => stateString;
      set => stateString = value;
  }


  public void setStateString(String stateString) {
     this.stateString = stateString;
  }

  [XmlElement("name")]
  public string? TaskName
  {
      get => taskName;
      set => taskName = value;
  }


  public void setTaskName(String taskName) {
     this.taskName = taskName;
  }


  // Path("initialize")
  [XmlRoot("results")]
  public class InitializationStatusList : BaseApiListBean<InitializationStatus> {
    [XmlElement("initializationStatuss")]
    [XmlElement("initializationStatus")]
   
    public override List<InitializationStatus>? GetItems() => items;

    public override void SetItems(List<InitializationStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InitializationStatus>? items)
    {
        this.items = items;
    }
  }
}

}