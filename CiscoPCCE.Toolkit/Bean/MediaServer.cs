using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class MediaServer : BaseApiBean {
  private bool? ftpEnabled;
  private string? ftpPassword;
  private int? ftpPort;
  private string? ftpUserName;
  private string? hostName;
  private string? ip;

  public bool? FtpEnabled
  {
      get => ftpEnabled;
      set => ftpEnabled = value;
  }


  public void setFtpEnabled(bool? ftpEnabled) {
     this.ftpEnabled = ftpEnabled;
  }

  public string? FtpPassword
  {
      get => ftpPassword;
      set => ftpPassword = value;
  }


  public void setFtpPassword(String ftpPassword) {
     this.ftpPassword = ftpPassword;
  }

  public int? FtpPort
  {
      get => ftpPort;
      set => ftpPort = value;
  }


  public void setFtpPort(int? ftpPort) {
     this.ftpPort = ftpPort;
  }

  public string? FtpUserName
  {
      get => ftpUserName;
      set => ftpUserName = value;
  }


  public void setFtpUserName(String ftpUserName) {
     this.ftpUserName = ftpUserName;
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