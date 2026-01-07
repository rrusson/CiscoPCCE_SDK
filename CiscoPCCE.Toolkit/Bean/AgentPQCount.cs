using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("AgentPQCount")]
public class AgentPQCount : BaseApiBean {
      
  public string? RefURL { get; set; }

  public int? pqCount { get; set; }

  [XmlElement("pqNameList")]
  [XmlElement("pqName")]
  public List<PQName>? pqNameList { get; set; }

}

}