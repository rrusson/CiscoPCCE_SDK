using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("administrator")
[XmlRoot("userGroupBase")]
public class UserGroupBase : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? domainName;
  private string? idFromRefUrl;
  private string? refURL;
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

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
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
  public class UserGroupBaseList : BaseApiListBean<UserGroupBase> {
    [XmlElement("userGroupBases")]
    [XmlElement("userGroupBase")]
   
    public override List<UserGroupBase>? GetItems() => items;

    public override void SetItems(List<UserGroupBase>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<UserGroupBase>? items)
    {
        this.items = items;
    }
  }
}

}