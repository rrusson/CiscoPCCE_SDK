using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("capacityInfo")]
public class CapacityInfo : BaseApiBean {
  private List<CapacityCheckResult>? capacityCheckResults;

  [XmlElement("capacityRules")]
  [XmlElement("capacityRule")]
  public List<CapacityCheckResult>? CapacityCheckResults
  {
      get => capacityCheckResults;
      set => capacityCheckResults = value;
  }


  public void setCapacityCheckResults(List<CapacityCheckResult> capacityCheckResults) {
     this.capacityCheckResults = capacityCheckResults;
  }


}

}