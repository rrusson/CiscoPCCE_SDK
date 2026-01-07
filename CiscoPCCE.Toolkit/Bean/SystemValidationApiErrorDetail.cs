using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class SystemValidationApiErrorDetail : BaseApiBean {
          
  public string? Actual { get; set; }

  public string? Expected { get; set; }

  public int? Max { get; set; }

  public int? Min { get; set; }

  public string? Name { get; set; }

}

}