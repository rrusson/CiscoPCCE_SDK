using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("initialize")
[XmlRoot("results")]
public class InitializationStatusResults : BaseApiBean {
  private StateEnum state;
  private List<InitializationStatus>? statusList;

  [XmlElement("state")]
  public StateEnum State
  {
      get => state;
      set => state = value;
  }


  public void setState(StateEnum state) {
     this.state = state;
  }

  [XmlElement("initializationStatuses")]
  [XmlElement("initializationStatus")]
  public List<InitializationStatus>? StatusList
  {
      get => statusList;
      set => statusList = value;
  }


  public void setStatusList(List<InitializationStatus> statusList) {
     this.statusList = statusList;
  }


  // Path("initialize")
  [XmlRoot("results")]
  public class InitializationStatusResultsList : BaseApiListBean<InitializationStatusResults> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<InitializationStatusResults>? GetItems() => items;

    public override void SetItems(List<InitializationStatusResults>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InitializationStatusResults>? items)
    {
        this.items = items;
    }
  }
}

}