using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("status")
[XmlRoot("results")]
public class StatusResults : BaseApiBean {
  private List<Status>? statuses;

  [XmlElement("statuses")]
  [XmlElement("status")]
  public List<Status>? Statuses
  {
      get => statuses;
      set => statuses = value;
  }

  // Path("status")
  [XmlRoot("results")]
  public class StatusResultsList : BaseApiListBean<StatusResults> {    public override List<StatusResults>? GetItems() => items;

    public override void SetItems(List<StatusResults>? value) => items = value;

  }
}

}