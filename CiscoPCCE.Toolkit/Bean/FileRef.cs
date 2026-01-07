using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class FileRef : BaseApiBean {
  private string? refURL;

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}

}