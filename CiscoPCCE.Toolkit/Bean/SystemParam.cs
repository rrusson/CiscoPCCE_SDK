using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("systemParam")]
public class SystemParam : BaseApiBean {
  private Media media;
  private Security security;

  public Media Media
  {
      get => media;
      set => media = value;
  }


  public void setMedia(Media media) {
     this.media = media;
  }

  public Security Security
  {
      get => security;
      set => security = value;
  }


  public void setSecurity(Security security) {
     this.security = security;
  }


}

}