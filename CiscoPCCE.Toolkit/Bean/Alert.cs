using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Alert : BaseApiBean {
    
  [XmlElement("apiErrors")]
  public ApiErrors Errors { get; set; }

  public Machine Machine { get; set; }

}

}