using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class StreamingConnectionParams : BaseApiBean {
  private string? ldPassword;
  private string? ldSchemaUrl;
  private string? ldServiceIP;
  private int? ldServicePort;
  private string? ldTokenUrl;
  private string? ldUserId;
  private int? maxPoolSize;
  private int? minPoolSize;
  private string? password;
  private string? userId;
  private int? webSocketPort;

  public string? LdPassword
  {
      get => ldPassword;
      set => ldPassword = value;
  }


  public void setLdPassword(String ldPassword) {
     this.ldPassword = ldPassword;
  }

  public string? LdSchemaUrl
  {
      get => ldSchemaUrl;
      set => ldSchemaUrl = value;
  }


  public void setLdSchemaUrl(String ldSchemaUrl) {
     this.ldSchemaUrl = ldSchemaUrl;
  }

  public string? LdServiceIP
  {
      get => ldServiceIP;
      set => ldServiceIP = value;
  }


  public void setLdServiceIP(String ldServiceIP) {
     this.ldServiceIP = ldServiceIP;
  }

  public int? LdServicePort
  {
      get => ldServicePort;
      set => ldServicePort = value;
  }


  public void setLdServicePort(int? ldServicePort) {
     this.ldServicePort = ldServicePort;
  }

  public string? LdTokenUrl
  {
      get => ldTokenUrl;
      set => ldTokenUrl = value;
  }


  public void setLdTokenUrl(String ldTokenUrl) {
     this.ldTokenUrl = ldTokenUrl;
  }

  public string? LdUserId
  {
      get => ldUserId;
      set => ldUserId = value;
  }


  public void setLdUserId(String ldUserId) {
     this.ldUserId = ldUserId;
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

  public string? UserId
  {
      get => userId;
      set => userId = value;
  }


  public void setUserId(String userId) {
     this.userId = userId;
  }

  public int? WebSocketPort
  {
      get => webSocketPort;
      set => webSocketPort = value;
  }


  public void setWebSocketPort(int? webSocketPort) {
     this.webSocketPort = webSocketPort;
  }


}

}