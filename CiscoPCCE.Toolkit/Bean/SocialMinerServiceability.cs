using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("Serviceability")]
public class SocialMinerServiceability : BaseApiBean {
  
  public SocialMinerVersion Version { get; set; }

}

}