using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("GroupType")]
public class GroupType : BaseApiBean {
    
  public Machines Machines { get; set; }

  public string? Name { get; set; }

}

}