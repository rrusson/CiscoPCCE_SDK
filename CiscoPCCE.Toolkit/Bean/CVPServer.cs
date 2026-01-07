using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("CVP")]
public class CVPServer : BaseApiBean {
                          
  public string? BaseUrlfromRefUrl { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public ICMServiceConfig Icm { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public InfrastructureServiceConfig Infrastructure { get; set; }

  public IVRServiceConfig Ivr { get; set; }

  public MediaServerConfig MediaServer { get; set; }

  public string? RefURL { get; set; }

  public SIPServiceConfig Sip { get; set; }

  public VXMLServiceConfig Vxml { get; set; }

}

}