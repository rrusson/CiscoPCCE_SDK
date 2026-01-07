using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("routingtype")
[XmlRoot("routingType")]
public class RoutingTypeBean : BaseApiBean {
  private string? machineType;
  private State state;
  private int? type;

  public string? MachineType
  {
      get => machineType;
      set => machineType = value;
  }


  public void setMachineType(String machineType) {
     this.machineType = machineType;
  }

  public State State
  {
      get => state;
      set => state = value;
  }


  public void setState(State state) {
     this.state = state;
  }

  public int? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(int? type) {
     this.type = type;
  }


  // Path("routingtype")
  [XmlRoot("results")]
  public class RoutingTypeBeanList : BaseApiListBean<RoutingTypeBean> {
    [XmlElement("routingTypes")]
    [XmlElement("routingType")]
   
    public override List<RoutingTypeBean>? GetItems() => items;

    public override void SetItems(List<RoutingTypeBean>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoutingTypeBean>? items)
    {
        this.items = items;
    }
  }
}

}