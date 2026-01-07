using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class NameNotFoundErrorDetail : BaseApiBean {
    
  public string? Name { get; set; }

  public string? Type { get; set; }

}

}