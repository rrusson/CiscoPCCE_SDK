using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("Login")]
public class ECELogin : BaseApiBean {
    
  public string? Password { get; set; }

  public string? UserName { get; set; }

}

}