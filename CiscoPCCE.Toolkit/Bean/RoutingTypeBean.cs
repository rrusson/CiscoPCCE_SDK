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

  public State State
  {
      get => state;
      set => state = value;
  }

  public int? Type
  {
      get => type;
      set => type = value;
  }

  // Path("routingtype")
  [XmlRoot("results")]
  public class RoutingTypeBeanList : BaseApiListBean<RoutingTypeBean> {    public override List<RoutingTypeBean>? GetItems() => items;

    public override void SetItems(List<RoutingTypeBean>? value) => items = value;

  }
}

}