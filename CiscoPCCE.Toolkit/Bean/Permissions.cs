using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("##default")]
public class Permissions : BaseApiBean {
    
  public string? Id { get; set; }

  public List<User>? UserList { get; set; }

}

}