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


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }


  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public RoutingTypeBeanList RoutingTypes
  {
      get => routingTypes;
      set => routingTypes = value;
  }


  public void setRoutingTypes(RoutingTypeBeanList routingTypes) {
     this.routingTypes = routingTypes;
  }


  // Path("routingtype")
  [XmlRoot("results")]
  public class DatacenterRoutingTypeBeanList : BaseApiListBean<DatacenterRoutingTypeBean> {
    [XmlElement("datacenterRoutingTypes")]
    [XmlElement("datacenterRoutingType")]
   
    public override List<DatacenterRoutingTypeBean>? GetItems() => items;

    public override void SetItems(List<DatacenterRoutingTypeBean>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DatacenterRoutingTypeBean>? items)
    {
        this.items = items;
    }
  }
}

}