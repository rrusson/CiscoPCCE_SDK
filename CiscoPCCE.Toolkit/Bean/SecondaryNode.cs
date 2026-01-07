using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class SecondaryNode : BaseApiBean {
  private string? host;

  public string? Host
  {
      get => host;
      set => host = value;
  }


  public void setHost(String host) {
     this.host = host;
  }


}

}