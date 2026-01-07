using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class CapacityApiErrorDetail : BaseApiBean {
      
  public int? Actual { get; set; }

  public int? Max { get; set; }

  public string? Name { get; set; }

}

}