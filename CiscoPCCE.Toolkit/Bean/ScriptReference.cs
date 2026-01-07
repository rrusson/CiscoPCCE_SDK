using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("reference")]
public class ScriptReference : BaseApiBean {
        
  public bool? Deleted { get; set; }

  public int? Id { get; set; }

  public string? Name { get; set; }

  [XmlElement("##default")]
  public List<int?>? Versions { get; set; }

}

}