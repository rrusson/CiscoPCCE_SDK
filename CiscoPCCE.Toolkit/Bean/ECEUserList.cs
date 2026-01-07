using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("users")]
public class ECEUserList : BaseApiBean {
  
  public List<ECEUser>? Users { get; set; }

}

}