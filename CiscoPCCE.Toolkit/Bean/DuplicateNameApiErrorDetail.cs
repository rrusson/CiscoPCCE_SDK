using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class DuplicateNameApiErrorDetail : BaseApiBean {
    
  public bool? Deleted { get; set; }

  public string? Scope { get; set; }

}

}