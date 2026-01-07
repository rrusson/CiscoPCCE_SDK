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

  public int? DeploymentType
  {
      get => deploymentType;
      set => deploymentType = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? SupervisorLoginAllowed
  {
      get => supervisorLoginAllowed;
      set => supervisorLoginAllowed = value;
  }

  // Path("deployment")
  [XmlRoot("results")]
  public class DeploymentList : BaseApiListBean<Deployment> {    public override List<Deployment>? GetItems() => items;

    public override void SetItems(List<Deployment>? value) => items = value;

  }
}

}