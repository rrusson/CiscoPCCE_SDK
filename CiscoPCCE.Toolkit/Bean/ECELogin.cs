using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("Login")]
public class ECELogin : BaseApiBean {
  private string? password;
  private string? userName;

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

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