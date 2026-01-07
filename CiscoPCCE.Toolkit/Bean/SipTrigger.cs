using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class SipTrigger : BaseApiBean {
  private List<string?>? labels;

  [XmlElement("label")]
  public List<string?>? Labels
  {
      get => labels;
      set => labels = value;
  }


  public void setLabels(List<String> labels) {
     this.labels = labels;
  }


}

}