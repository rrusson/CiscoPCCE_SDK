using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("EnterpriseDatabaseConfig")]
public class FinesseEnterpriseDatabaseConfig : BaseApiBean {
  private string? backupHost;
  private string? databaseName;
  private string? domain;
  private string? host;
  private string? password;
  private int port;
  private string? userName;

  public string? BackupHost
  {
      get => backupHost;
      set => backupHost = value;
  }


  public void setBackupHost(String backupHost) {
     this.backupHost = backupHost;
  }

  public string? DatabaseName
  {
      get => databaseName;
      set => databaseName = value;
  }


  public void setDatabaseName(String databaseName) {
     this.databaseName = databaseName;
  }

  public string? Domain
  {
      get => domain;
      set => domain = value;
  }


  public void setDomain(String domain) {
     this.domain = domain;
  }

  public string? Host
  {
      get => host;
      set => host = value;
  }


  public void setHost(String host) {
     this.host = host;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public int Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int port) {
     this.port = port;
  }

  [XmlElement("username")]
  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


}

}