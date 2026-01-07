using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class Node : BaseApiBean {
  private bool? active;
  private string? deviceType;
  private string? hostName;
  private string? ip;

  public bool? Active
  {
      get => active;
      set => active = value;
  }


  public void setActive(Boolean active) {
     this.active = active;
  }

  public string? DeviceType
  {
      get => deviceType;
      set => deviceType = value;
  }


  public void setDeviceType(String deviceType) {
     this.deviceType = deviceType;
  }

  public string? HostName
  {
      get => hostName;
      set => hostName = value;
  }


  public void setHostName(String hostName) {
     this.hostName = hostName;
  }

  public string? Ip
  {
      get => ip;
      set => ip = value;
  }


  public void setIp(String ip) {
     this.ip = ip;
  }


}

}