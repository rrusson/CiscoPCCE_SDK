using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("MRconfig")]
public class MRConfig : BaseApiBean {
  private bool? enabled;
  private string? hostA;
  private string? hostB;
  private int port;

  public bool? Enabled
  {
      get => enabled;
      set => enabled = value;
  }


  public void setEnabled(bool? enabled) {
     this.enabled = enabled;
  }

  public string? HostA
  {
      get => hostA;
      set => hostA = value;
  }


  public void setHostA(String hostA) {
     this.hostA = hostA;
  }

  public string? HostB
  {
      get => hostB;
      set => hostB = value;
  }


  public void setHostB(String hostB) {
     this.hostB = hostB;
  }

  public int Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int port) {
     this.port = port;
  }


}

}