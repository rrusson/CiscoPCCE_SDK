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


  public void setComponents(List<Component> components) {
     this.components = components;
  }


  // Path("tracelevel")
  [XmlRoot("results")]
  public class TraceLevelsList : BaseApiListBean<TraceLevels> {
    [XmlElement("traceLevelss")]
    [XmlElement("traceLevels")]
   
    public override List<TraceLevels>? GetItems() => items;

    public override void SetItems(List<TraceLevels>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TraceLevels>? items)
    {
        this.items = items;
    }
  }
}

}