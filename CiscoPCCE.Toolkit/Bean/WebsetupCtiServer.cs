using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("ctiServer")]
public class WebsetupCtiServer : BaseApiBean {
              
  public string? CgId { get; set; }

  public string? PortIndex { get; set; }

  public string? Side { get; set; }

  public string? SideAPrivateAddress { get; set; }

  public string? SideAPublicAddress { get; set; }

  public string? SideBPrivateAddress { get; set; }

  public string? SideBPublicAddress { get; set; }

}

}