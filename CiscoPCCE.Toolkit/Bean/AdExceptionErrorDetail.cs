using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class AdExceptionErrorDetail : BaseApiBean {
      
  public int Code { get; set; }

  public string? Key { get; set; }

  public string? Value { get; set; }

}

}