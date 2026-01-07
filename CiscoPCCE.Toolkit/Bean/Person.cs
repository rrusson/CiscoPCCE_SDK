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

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public bool? DigitalChannel
  {
      get => digitalChannel;
      set => digitalChannel = value;
  }

  public bool? EcePerson
  {
      get => ecePerson;
      set => ecePerson = value;
  }

  public string? EmailAddress
  {
      get => emailAddress;
      set => emailAddress = value;
  }

  public string? FirstName
  {
      get => firstName;
      set => firstName = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? LastName
  {
      get => lastName;
      set => lastName = value;
  }

  public bool? LoginEnabled
  {
      get => loginEnabled;
      set => loginEnabled = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Password
  {
      get => password;
      set => password = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public string? ScreenName
  {
      get => screenName;
      set => screenName = value;
  }

  public bool? SsoEnabled
  {
      get => ssoEnabled;
      set => ssoEnabled = value;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }

  // Path("agent")
  [XmlRoot("results")]
  public class PersonList : BaseApiListBean<Person> {    public override List<Person>? GetItems() => items;

    public override void SetItems(List<Person>? value) => items = value;

  }
}

}