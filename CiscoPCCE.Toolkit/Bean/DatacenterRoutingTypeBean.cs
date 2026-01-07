using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("routingtype")
[XmlRoot("datacenterRoutingType")]
public class DatacenterRoutingTypeBean : BaseApiBean {
  private ReferenceBean datacenter;
  private ReferenceBean peripheralSet;
  private RoutingTypeBeanList routingTypes;

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }

  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }

  public RoutingTypeBeanList RoutingTypes
  {
      get => routingTypes;
      set => routingTypes = value;
  }

  // Path("routingtype")
  [XmlRoot("results")]
  public class DatacenterRoutingTypeBeanList : BaseApiListBean<DatacenterRoutingTypeBean> {    public override List<DatacenterRoutingTypeBean>? GetItems() => items;

    public override void SetItems(List<DatacenterRoutingTypeBean>? value) => items = value;

  }
}

}