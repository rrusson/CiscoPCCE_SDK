using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("##default")]
public class ConnectionParams : BaseApiBean {
  private int? maxPoolSize;
  private int? minPoolSize;
  private string? password;
  private string? userId;

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


}

}