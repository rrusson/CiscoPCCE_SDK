using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("peripheralGateway")]
public class WebsetupPG : BaseApiBean {
                        
  public string? LogicalId { get; set; }

  public string? PgClientType { get; set; }

  public string? PgId { get; set; }

  [XmlElement("pims")]
  [XmlElement("pim")]
  public List<WebsetupPim>? Pims { get; set; }

  public string? PortIndex { get; set; }

  public string? RouterSideAPublicAddress { get; set; }

  public string? RouterSideBPublicAddress { get; set; }

  public string? Side { get; set; }

  public string? SideAPrivateAddress { get; set; }

  public string? SideAPublicAddress { get; set; }

  public string? SideBPrivateAddress { get; set; }

  public string? SideBPublicAddress { get; set; }

}

}