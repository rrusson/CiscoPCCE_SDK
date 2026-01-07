using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class SipServerElementErrorDetail : BaseApiBean {
        
  public string? Address { get; set; }

  public string? Field { get; set; }

  public int? Max { get; set; }

  public int? Min { get; set; }

}

}