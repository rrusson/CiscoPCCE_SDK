using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class DBConnectionParams : BaseApiBean {
  private string? database;
  private string? dbEncoding;
  private string? dbInstance;
  private string? host;
  private int? maxPoolSize;
  private int? minPoolSize;
  private string? password;
  private int? port;
  private string? userId;

  public string? Database
  {
      get => database;
      set => database = value;
  }


  public void setDatabase(String database) {
     this.database = database;
  }

  public string? DbEncoding
  {
      get => dbEncoding;
      set => dbEncoding = value;
  }


  public void setDbEncoding(String dbEncoding) {
     this.dbEncoding = dbEncoding;
  }

  public string? DbInstance
  {
      get => dbInstance;
      set => dbInstance = value;
  }


  public void setDbInstance(String dbInstance) {
     this.dbInstance = dbInstance;
  }

  public string? Host
  {
      get => host;
      set => host = value;
  }


  public void setHost(String host) {
     this.host = host;
  }

  public int? MaxPoolSize
  {
      get => maxPoolSize;
      set => maxPoolSize = value;
  }


  public void setMaxPoolSize(int? maxPoolSize) {
     this.maxPoolSize = maxPoolSize;
  }

  public int? MinPoolSize
  {
      get => minPoolSize;
      set => minPoolSize = value;
  }


  public void setMinPoolSize(int? minPoolSize) {
     this.minPoolSize = minPoolSize;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public int? Port
  {
      get => port;
      set => port = value;
  }


  public void setPort(int? port) {
     this.port = port;
  }

  public string? UserId
  {
      get => userId;
      set => userId = value;
  }


  public void setUserId(String userId) {
     this.userId = userId;
  }


}

}