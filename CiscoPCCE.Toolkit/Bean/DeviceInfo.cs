using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class DeviceInfo : BaseApiBean {
  private List<string?>? locations;
  private string? typeName;

  [XmlElement("locations")]
  [XmlElement("location")]
  public List<string?>? Locations
  {
      get => locations;
      set => locations = value;
  }


  public void setLocations(List<String> locations) {
     this.locations = locations;
  }

  public string? TypeName
  {
      get => typeName;
      set => typeName = value;
  }


  public void setTypeName(String typeName) {
     this.typeName = typeName;
  }


}

}