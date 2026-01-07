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

  public ReferenceBean Customer
  {
      get => customer;
      set => customer = value;
  }


  public void setCustomer(ReferenceBean customer) {
     this.customer = customer;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  [XmlElement("departments")]
  [XmlElement("department")]
  public List<ReferenceBean>? Departments
  {
      get => departments;
      set => departments = value;
  }


  public void setDepartments(List<ReferenceBean> departments) {
     this.departments = departments;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? DomainName
  {
      get => domainName;
      set => domainName = value;
  }


  public void setDomainName(String domainName) {
     this.domainName = domainName;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? ReadOnly
  {
      get => readOnly;
      set => readOnly = value;
  }


  public void setReadOnly(Boolean readOnly) {
     this.readOnly = readOnly;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public ReferenceBean Role
  {
      get => role;
      set => role = value;
  }


  public void setRole(ReferenceBean role) {
     this.role = role;
  }

  public bool? SsoEnabled
  {
      get => ssoEnabled;
      set => ssoEnabled = value;
  }


  public void setSsoEnabled(bool? ssoEnabled) {
     this.ssoEnabled = ssoEnabled;
  }

  public bool? Supervisor
  {
      get => supervisor;
      set => supervisor = value;
  }


  public void setSupervisor(bool? supervisor) {
     this.supervisor = supervisor;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }


  public void setUserName(String userName) {
     this.userName = userName;
  }


  // Path("administrator")
  [XmlRoot("results")]
  public class AdministratorList : BaseApiListBean<Administrator> {
    [XmlElement("administrators")]
    [XmlElement("administrator")]
   
    public override List<Administrator>? GetItems() => items;

    public override void SetItems(List<Administrator>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Administrator>? items)
    {
        this.items = items;
    }
  }
}

}