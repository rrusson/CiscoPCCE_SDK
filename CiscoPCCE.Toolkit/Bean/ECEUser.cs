using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("user")]
public class ECEUser : BaseApiBean {
  private ECEDepartment department;
  private int? externalId;
  private string? firstName;
  private int? id;
  private string? lastName;
  private string? loginId;
  private string? password;
  private string? screenName;

  public ECEDepartment Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ECEDepartment department) {
     this.department = department;
  }

  public int? ExternalId
  {
      get => externalId;
      set => externalId = value;
  }


  public void setExternalId(int? externalId) {
     this.externalId = externalId;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }


  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public string? LoginId
  {
      get => loginId;
      set => loginId = value;
  }


  public void setLoginId(String loginId) {
     this.loginId = loginId;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }


  public void setPassword(String password) {
     this.password = password;
  }

  public string? ScreenName
  {
      get => screenName;
      set => screenName = value;
  }


  public void setScreenName(String screenName) {
     this.screenName = screenName;
  }


}

}