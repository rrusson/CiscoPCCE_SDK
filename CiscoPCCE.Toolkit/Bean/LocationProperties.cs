using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("locationproperties")
[XmlRoot("locationProperties")]
public class LocationProperties : BaseApiBean {
  private string? locationRoutingCodeInsertOption;

  public string? LocationRoutingCodeInsertOption
  {
      get => locationRoutingCodeInsertOption;
      set => locationRoutingCodeInsertOption = value;
  }

  // Path("locationproperties")
  [XmlRoot("results")]
  public class LocationPropertiesList : BaseApiListBean<LocationProperties> {    public override List<LocationProperties>? GetItems() => items;

    public override void SetItems(List<LocationProperties>? value) => items = value;

  }
}

}