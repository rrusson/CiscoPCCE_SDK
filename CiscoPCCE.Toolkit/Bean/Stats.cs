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


  public void setNumberOfAgentsLoggedIn(int numberOfAgentsLoggedIn) {
     this.numberOfAgentsLoggedIn = numberOfAgentsLoggedIn;
  }


  // Path("stats")
  [XmlRoot("results")]
  public class StatsList : BaseApiListBean<Stats> {
    [XmlElement("statss")]
    [XmlElement("stats")]
   
    public override List<Stats>? GetItems() => items;

    public override void SetItems(List<Stats>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Stats>? items)
    {
        this.items = items;
    }
  }
}

}