using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class NetworkLabelGlobalSetting : BaseApiBean {
      
  [XmlElement("cmLabel")]
  public string? CMLabel { get; set; }

  [XmlElement("cvpLabels")]
  [XmlElement("cvpLabel")]
  public List<CVPLabel>? CVPLabels { get; set; }

  [XmlElement("outboundLabel")]
  public string? OutboundLabel { get; set; }

}

}