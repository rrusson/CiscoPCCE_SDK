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


  public void setDatacenterRoutingTypes(DatacenterRoutingTypeBeanList datacenterRoutingTypes) {
     this.datacenterRoutingTypes = datacenterRoutingTypes;
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
  public class DCAwareRoutingTypeBeanListList : BaseApiListBean<DCAwareRoutingTypeBeanList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<DCAwareRoutingTypeBeanList>? GetItems() => items;

    public override void SetItems(List<DCAwareRoutingTypeBeanList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DCAwareRoutingTypeBeanList>? items)
    {
        this.items = items;
    }
  }
}

}