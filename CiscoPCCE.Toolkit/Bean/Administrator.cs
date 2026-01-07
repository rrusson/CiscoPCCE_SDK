using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("administrator")
[XmlRoot("administrator")]
public class Administrator : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean customer;
  private ReferenceBean department;
  private List<ReferenceBean>? departments;
  private string? description;
  private string? domainName;
  private string? idFromRefUrl;
  private bool? readOnly;
  private string? refURL;
  private ReferenceBean role;
  private bool? ssoEnabled;
  private bool? supervisor;
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

  public ReferenceBean Customer
  {
      get => customer;
      set => customer = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  [XmlElement("departments")]
  [XmlElement("department")]
  public List<ReferenceBean>? Departments
  {
      get => departments;
      set => departments = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? DomainName
  {
      get => domainName;
      set => domainName = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? ReadOnly
  {
      get => readOnly;
      set => readOnly = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public ReferenceBean Role
  {
      get => role;
      set => role = value;
  }

  public bool? SsoEnabled
  {
      get => ssoEnabled;
      set => ssoEnabled = value;
  }

  public bool? Supervisor
  {
      get => supervisor;
      set => supervisor = value;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }

  // Path("administrator")
  [XmlRoot("results")]
  public class AdministratorList : BaseApiListBean<Administrator> {    public override List<Administrator>? GetItems() => items;

    public override void SetItems(List<Administrator>? value) => items = value;

  }
}

}