using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("agent")
[XmlRoot("person")]
public class Person : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private bool? digitalChannel;
  private bool? ecePerson;
  private string? emailAddress;
  private string? firstName;
  private string? idFromRefUrl;
  private string? lastName;
  private bool? loginEnabled;
  private bool? markDeletable;
  private string? password;
  private string? refURL;
  private string? screenName;
  private bool? ssoEnabled;
  private string? userName;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public bool? DigitalChannel
  {
      get => digitalChannel;
      set => digitalChannel = value;
  }


  public void setDigitalChannel(Boolean digitalChannel) {
     this.digitalChannel = digitalChannel;
  }

  public bool? EcePerson
  {
      get => ecePerson;
      set => ecePerson = value;
  }


  public void setEcePerson(Boolean ecePerson) {
     this.ecePerson = ecePerson;
  }

  public string? EmailAddress
  {
      get => emailAddress;
      set => emailAddress = value;
  }


  public void setEmailAddress(String emailAddress) {
     this.emailAddress = emailAddress;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }


  public void setFirstName(String firstName) {
     this.firstName = firstName;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }


  public void setLastName(String lastName) {
     this.lastName = lastName;
  }

  public bool? LoginEnabled
  {
      get => loginEnabled;
      set => loginEnabled = value;
  }


  public void setLoginEnabled(Boolean loginEnabled) {
     this.loginEnabled = loginEnabled;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
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

  public string? ScreenName
  {
      get => screenName;
      set => screenName = value;
  }


  public void setScreenName(String screenName) {
     this.screenName = screenName;
  }

  public bool? SsoEnabled
  {
      get => ssoEnabled;
      set => ssoEnabled = value;
  }


  public void setSsoEnabled(Boolean ssoEnabled) {
     this.ssoEnabled = ssoEnabled;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


  // Path("agent")
  [XmlRoot("results")]
  public class PersonList : BaseApiListBean<Person> {
    [XmlElement("persons")]
    [XmlElement("person")]
   
    public override List<Person>? GetItems() => items;

    public override void SetItems(List<Person>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Person>? items)
    {
        this.items = items;
    }
  }
}

}