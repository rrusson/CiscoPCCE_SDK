using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("tracelevel")
[XmlRoot("traceLevels")]
public class TraceLevels : BaseApiBean {
  private List<Component>? components;

  [XmlElement("component")]
  public List<Component>? Components
  {
      get => components;
      set => components = value;
  }

  // Path("tracelevel")
  [XmlRoot("results")]
  public class TraceLevelsList : BaseApiListBean<TraceLevels> {    public override List<TraceLevels>? GetItems() => items;

    public override void SetItems(List<TraceLevels>? value) => items = value;

  }
}

}