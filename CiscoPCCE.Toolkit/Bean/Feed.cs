using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("Feed")]
public class Feed : BaseApiBean {
            
  public int? ChangeStamp { get; set; }

  public string? Description { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

  [XmlElement("tags")]
  [XmlElement("tag")]
  public List<string?>? Tags { get; set; }

  public int? Type { get; set; }

}

}