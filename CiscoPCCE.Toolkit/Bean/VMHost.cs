using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vmHost")]
public class VMHost : BaseApiBean {
  private string? address;
  private int? changeStamp;
  private string? name;
  private string? password;
  private string? refURL;
  private bool? systemDefault;
  private string? userName;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public bool? SystemDefault
  {
      get => systemDefault;
      set => systemDefault = value;
  }


  public void setSystemDefault(Boolean systemDefault) {
     this.systemDefault = systemDefault;
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