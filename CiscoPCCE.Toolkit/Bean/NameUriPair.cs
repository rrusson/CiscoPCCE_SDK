using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class NameUriPair : BaseApiBean {
  private string? name;
  private string? refURL;

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

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