using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("VVB")]
public class VVBServer : BaseApiBean {
                        
  [XmlElement("applications")]
  [XmlElement("application")]
  public List<Application>? Applications { get; set; }

  [XmlElement("asrServers")]
  [XmlElement("asrServer")]
  public List<AsrServer>? AsrServers { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public MediaConfig Media { get; set; }

  public string? RefURL { get; set; }

  public SecurityConfig Security { get; set; }

  [XmlElement("ttsServers")]
  [XmlElement("ttsServer")]
  public List<TtsServer>? TtsServers { get; set; }

}

}