using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ttsServer")]
public class TtsServer : BaseApiBean {
  private int? port;
  private string? ttsServerName;

  public int? Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int? port) {
     this.port = port;
  }

  public string? TtsServerName
  {
      get => ttsServerName;
      set => ttsServerName = value;
  }


  public void setTtsServerName(String ttsServerName) {
     this.ttsServerName = ttsServerName;
  }


}

}