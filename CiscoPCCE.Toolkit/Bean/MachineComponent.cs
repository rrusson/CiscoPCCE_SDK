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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineComponentList : BaseApiListBean<MachineComponent> {    public override List<MachineComponent>? GetItems() => items;

    public override void SetItems(List<MachineComponent>? value) => items = value;

  }
}

}