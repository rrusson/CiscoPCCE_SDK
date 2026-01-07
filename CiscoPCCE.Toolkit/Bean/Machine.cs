using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class Machine : BaseApiBean {
  private string? host;
  private string? name;
  private string? refURL;
  private MachineType type;

  public string? Host
  {
      get => host;
      set => host = value;
  }


  public void setHost(String host) {
     this.host = host;
  }

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

  public MachineType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(MachineType type) {
     this.type = type;
  }


}

}