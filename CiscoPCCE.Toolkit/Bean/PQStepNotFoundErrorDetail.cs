using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class PQStepNotFoundErrorDetail : BaseApiBean {
    
  public string? PqName { get; set; }

  public int? Step { get; set; }

}

}