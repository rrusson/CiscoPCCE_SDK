using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("infrastructure")]
public class InfrastructureServiceConfig : BaseApiBean {
  private int? maxLogDirectorySize;
  private int? maxLogFileSize;
  private string? syslogBackupServer;
  private string? syslogBackupServerPort;
  private string? syslogSecondaryBackupServer;
  private string? syslogSecondaryBackupServerPort;
  private string? syslogSecondaryServer;
  private string? syslogSecondaryServerPort;
  private string? syslogServer;
  private string? syslogServerPort;

  public int? MaxLogDirectorySize
  {
      get => maxLogDirectorySize;
      set => maxLogDirectorySize = value;
  }


  public void setMaxLogDirectorySize(int? maxLogDirectorySize) {
     this.maxLogDirectorySize = maxLogDirectorySize;
  }

  public int? MaxLogFileSize
  {
      get => maxLogFileSize;
      set => maxLogFileSize = value;
  }


  public void setMaxLogFileSize(int? maxLogFileSize) {
     this.maxLogFileSize = maxLogFileSize;
  }

  public string? SyslogBackupServer
  {
      get => syslogBackupServer;
      set => syslogBackupServer = value;
  }


  public void setSyslogBackupServer(String syslogBackupServer) {
     this.syslogBackupServer = syslogBackupServer;
  }

  public string? SyslogBackupServerPort
  {
      get => syslogBackupServerPort;
      set => syslogBackupServerPort = value;
  }


  public void setSyslogBackupServerPort(String syslogBackupServerPort) {
     this.syslogBackupServerPort = syslogBackupServerPort;
  }

  public string? SyslogSecondaryBackupServer
  {
      get => syslogSecondaryBackupServer;
      set => syslogSecondaryBackupServer = value;
  }


  public void setSyslogSecondaryBackupServer(String syslogSecondaryBackupServer) {
     this.syslogSecondaryBackupServer = syslogSecondaryBackupServer;
  }

  public string? SyslogSecondaryBackupServerPort
  {
      get => syslogSecondaryBackupServerPort;
      set => syslogSecondaryBackupServerPort = value;
  }


  public void setSyslogSecondaryBackupServerPort(String syslogSecondaryBackupServerPort) {
     this.syslogSecondaryBackupServerPort = syslogSecondaryBackupServerPort;
  }

  public string? SyslogSecondaryServer
  {
      get => syslogSecondaryServer;
      set => syslogSecondaryServer = value;
  }


  public void setSyslogSecondaryServer(String syslogSecondaryServer) {
     this.syslogSecondaryServer = syslogSecondaryServer;
  }

  public string? SyslogSecondaryServerPort
  {
      get => syslogSecondaryServerPort;
      set => syslogSecondaryServerPort = value;
  }


  public void setSyslogSecondaryServerPort(String syslogSecondaryServerPort) {
     this.syslogSecondaryServerPort = syslogSecondaryServerPort;
  }

  public string? SyslogServer
  {
      get => syslogServer;
      set => syslogServer = value;
  }


  public void setSyslogServer(String syslogServer) {
     this.syslogServer = syslogServer;
  }

  public string? SyslogServerPort
  {
      get => syslogServerPort;
      set => syslogServerPort = value;
  }


  public void setSyslogServerPort(String syslogServerPort) {
     this.syslogServerPort = syslogServerPort;
  }


}

}