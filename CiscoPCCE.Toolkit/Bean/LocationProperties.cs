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


  public void setLocationRoutingCodeInsertOption(String locationRoutingCodeInsertOption) {
     this.locationRoutingCodeInsertOption = locationRoutingCodeInsertOption;
  }


  // Path("locationproperties")
  [XmlRoot("results")]
  public class LocationPropertiesList : BaseApiListBean<LocationProperties> {
    [XmlElement("locationPropertiess")]
    [XmlElement("locationProperties")]
   
    public override List<LocationProperties>? GetItems() => items;

    public override void SetItems(List<LocationProperties>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<LocationProperties>? items)
    {
        this.items = items;
    }
  }
}

}