using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("stats")
[XmlRoot("stats")]
public class Stats : BaseApiBean {
  private int numberOfAgentsLoggedIn;

  [XmlElement("numberOfAgentsLoggedIn")]
  public int NumberOfAgentsLoggedIn
  {
      get => numberOfAgentsLoggedIn;
      set => numberOfAgentsLoggedIn = value;
  }

  // Path("stats")
  [XmlRoot("results")]
  public class StatsList : BaseApiListBean<Stats> {    public override List<Stats>? GetItems() => items;

    public override void SetItems(List<Stats>? value) => items = value;

  }
}

}