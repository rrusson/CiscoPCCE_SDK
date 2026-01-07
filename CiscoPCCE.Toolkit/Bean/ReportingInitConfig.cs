using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("reportingConfig")]
public class ReportingInitConfig : BaseApiBean {
  private string? deviceId;
  private string? hostName;
  private string? ipAddress;

  public string? DeviceId
  {
      get => deviceId;
      set => deviceId = value;
  }


  public void setDeviceId(String deviceId) {
     this.deviceId = deviceId;
  }

  public string? HostName
  {
      get => hostName;
      set => hostName = value;
  }


  public void setHostName(String hostName) {
     this.hostName = hostName;
  }

  public string? IpAddress
  {
      get => ipAddress;
      set => ipAddress = value;
  }


  public void setIpAddress(String ipAddress) {
     this.ipAddress = ipAddress;
  }


}

}