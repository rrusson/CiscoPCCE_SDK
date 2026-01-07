using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("component")]
public class MachineComponent : BaseApiBean {
  private string? name;
  private string? refURL;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineComponentList : BaseApiListBean<MachineComponent> {
    [XmlElement("components")]
    [XmlElement("component")]
   
    public override List<MachineComponent>? GetItems() => items;

    public override void SetItems(List<MachineComponent>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MachineComponent>? items)
    {
        this.items = items;
    }
  }
}

}