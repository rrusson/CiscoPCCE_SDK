using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CardPosition : BaseApiBean {
  private int position;
  private string? refURL;

  public int Position
  {
      get => position;
      set => position = value;
  }


  public void setPosition(int position) {
     this.position = position;
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