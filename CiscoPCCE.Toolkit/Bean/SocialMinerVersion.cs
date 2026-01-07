using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class SocialMinerVersion : BaseApiBean {
  private string? vosActiveVersion;

  public string? VosActiveVersion
  {
      get => vosActiveVersion;
      set => vosActiveVersion = value;
  }


  public void setVosActiveVersion(String vosActiveVersion) {
     this.vosActiveVersion = vosActiveVersion;
  }


}

}