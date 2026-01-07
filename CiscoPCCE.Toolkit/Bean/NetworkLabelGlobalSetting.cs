using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class NetworkLabelGlobalSetting : BaseApiBean {
  private string? cMLabel;
  private List<CVPLabel>? cVPLabels;
  private string? outboundLabel;

  [XmlElement("cmLabel")]
  public string? CMLabel
  {
      get => cMLabel;
      set => cMLabel = value;
  }


  public void setCMLabel(String cMLabel) {
     this.cMLabel = cMLabel;
  }

  [XmlElement("cvpLabels")]
  [XmlElement("cvpLabel")]
  public List<CVPLabel>? CVPLabels
  {
      get => cVPLabels;
      set => cVPLabels = value;
  }


  public void setCVPLabels(List<CVPLabel> cVPLabels) {
     this.cVPLabels = cVPLabels;
  }

  [XmlElement("outboundLabel")]
  public string? OutboundLabel
  {
      get => outboundLabel;
      set => outboundLabel = value;
  }


  public void setOutboundLabel(String outboundLabel) {
     this.outboundLabel = outboundLabel;
  }


}

}