using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("locations")]
public class LocationList : BaseApiBean {
  private List<Location>? location;

  public List<Location>? Location
  {
      get => location;
      set => location = value;
  }


  public void setLocation(List<Location> location) {
     this.location = location;
  }


}

}