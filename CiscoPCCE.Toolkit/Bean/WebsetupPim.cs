using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("pim")]
public class WebsetupPim : BaseApiBean {
            
  public string? Address { get; set; }

  public string? MobileAgentCodec { get; set; }

  public string? Password { get; set; }

  public string? PeripheralId { get; set; }

  public string? Type { get; set; }

  public string? UserName { get; set; }

}

}