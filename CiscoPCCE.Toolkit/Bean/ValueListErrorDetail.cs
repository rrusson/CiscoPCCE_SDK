using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class ValueListErrorDetail : BaseApiBean {
  private List<string?>? invalidValues;

  [XmlElement("invalidValues")]
  [XmlElement("invalidValue")]
  public List<string?>? InvalidValues
  {
      get => invalidValues;
      set => invalidValues = value;
  }


  public void setInvalidValues(List<String> invalidValues) {
     this.invalidValues = invalidValues;
  }


}

}