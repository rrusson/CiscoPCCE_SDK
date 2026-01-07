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

  [XmlElement("initializationStatuses")]
  [XmlElement("initializationStatus")]
  public List<InitializationStatus>? StatusList
  {
      get => statusList;
      set => statusList = value;
  }

  // Path("initialize")
  [XmlRoot("results")]
  public class InitializationStatusResultsList : BaseApiListBean<InitializationStatusResults> {    public override List<InitializationStatusResults>? GetItems() => items;

    public override void SetItems(List<InitializationStatusResults>? value) => items = value;

  }
}

}