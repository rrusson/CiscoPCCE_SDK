using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class AgentPG : BaseApiBean {
              
  public ReferenceBean CmSubSideA { get; set; }

  public ReferenceBean CmSubSideB { get; set; }

  [XmlElement("configured")]
  public bool? Configured { get; set; }

  public string? FinessePassword { get; set; }

  public string? FinessePrimaryAddress { get; set; }

  public string? FinesseUserName { get; set; }

  public string? MobileAgentCodec { get; set; }

}

}