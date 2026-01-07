using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class VmLayoutErrorDetail : BaseApiBean {
  private List<VMLayoutResult>? layoutResults;

  [XmlElement("vmLayoutResults")]
  [XmlElement("vmLayoutResult")]
  public List<VMLayoutResult>? LayoutResults
  {
      get => layoutResults;
      set => layoutResults = value;
  }


  public void setLayoutResults(List<VMLayoutResult> layoutResults) {
     this.layoutResults = layoutResults;
  }


}

}