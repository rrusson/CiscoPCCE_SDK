using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("deployment")
[XmlRoot("deployment")]
public class Deployment : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private int? deploymentType;
  private string? idFromRefUrl;
  private bool? supervisorLoginAllowed;

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

  public int? DeploymentType
  {
      get => deploymentType;
      set => deploymentType = value;
  }


  public void setDeploymentType(int? deploymentType) {
     this.deploymentType = deploymentType;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? SupervisorLoginAllowed
  {
      get => supervisorLoginAllowed;
      set => supervisorLoginAllowed = value;
  }


  public void setSupervisorLoginAllowed(Boolean supervisorLoginAllowed) {
     this.supervisorLoginAllowed = supervisorLoginAllowed;
  }


  // Path("deployment")
  [XmlRoot("results")]
  public class DeploymentList : BaseApiListBean<Deployment> {
    [XmlElement("deployments")]
    [XmlElement("deployment")]
   
    public override List<Deployment>? GetItems() => items;

    public override void SetItems(List<Deployment>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Deployment>? items)
    {
        this.items = items;
    }
  }
}

}