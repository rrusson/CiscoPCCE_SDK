using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("routingtype")
[XmlRoot("results")]
public class DCAwareRoutingTypeBeanList : BaseApiBean {
  private DatacenterRoutingTypeBeanList datacenterRoutingTypes;
  private RoutingTypeBeanList routingTypes;

  public DatacenterRoutingTypeBeanList DatacenterRoutingTypes
  {
      get => datacenterRoutingTypes;
      set => datacenterRoutingTypes = value;
  }

  public RoutingTypeBeanList RoutingTypes
  {
      get => routingTypes;
      set => routingTypes = value;
  }

  // Path("routingtype")
  [XmlRoot("results")]
  public class DCAwareRoutingTypeBeanListList : BaseApiListBean<DCAwareRoutingTypeBeanList> {    public override List<DCAwareRoutingTypeBeanList>? GetItems() => items;

    public override void SetItems(List<DCAwareRoutingTypeBeanList>? value) => items = value;

  }
}

}