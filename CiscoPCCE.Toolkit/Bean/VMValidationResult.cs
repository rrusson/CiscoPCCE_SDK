using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vmValidationResult")]
public class VMValidationResult : BaseApiBean {
  private bool? isValid;
  private List<VMLayoutResult>? layoutResults;

  [XmlElement("isValid")]
  public bool? IsValid
  {
      get => isValid;
      set => isValid = value;
  }


  public void setIsValid(Boolean isValid) {
     this.isValid = isValid;
  }

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