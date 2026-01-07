using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class LoginSession : BaseApiBean {
  
  public int? SessionInactivityTimeout { get; set; }

}

}