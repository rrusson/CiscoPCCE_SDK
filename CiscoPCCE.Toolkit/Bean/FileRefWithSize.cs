using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class FileRefWithSize : BaseApiBean {
  private string? refURL;
  private long? size;

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public long? Size
  {
      get => size;
      set => size = value;
  }


  public void setSize(long? size) {
     this.size = size;
  }


}

}