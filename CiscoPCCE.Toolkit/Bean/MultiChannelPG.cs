using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class MultiChannelPG : BaseApiBean {
  
  [XmlElement("configured")]
  public bool? Configured { get; set; }

}

}