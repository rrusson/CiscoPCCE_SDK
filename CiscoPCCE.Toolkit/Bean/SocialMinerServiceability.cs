using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("Serviceability")]
public class SocialMinerServiceability : BaseApiBean {
  private SocialMinerVersion version;

  public SocialMinerVersion Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(SocialMinerVersion version) {
     this.version = version;
  }


}

}