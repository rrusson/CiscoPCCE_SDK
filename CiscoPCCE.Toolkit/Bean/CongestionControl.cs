using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("congestioncontrol")
[XmlRoot("congestionControl")]
public class CongestionControl : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private bool? congestionEnabled;
  private int? congestionTreatmentMode;
  private string? correlationId;
  private int? cpsCapacity;
  private int? cpsCapacityDefault;
  private ReferenceBean department;
  private int? deploymentType;
  private string? idFromRefUrl;
  private CongestionControlPermissionInfo permissionInfo;
  private string? systemDefaultLabel;

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

  public bool? CongestionEnabled
  {
      get => congestionEnabled;
      set => congestionEnabled = value;
  }

  public int? CongestionTreatmentMode
  {
      get => congestionTreatmentMode;
      set => congestionTreatmentMode = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public int? CpsCapacity
  {
      get => cpsCapacity;
      set => cpsCapacity = value;
  }

  public int? CpsCapacityDefault
  {
      get => cpsCapacityDefault;
      set => cpsCapacityDefault = value;
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

  public CongestionControlPermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  public string? SystemDefaultLabel
  {
      get => systemDefaultLabel;
      set => systemDefaultLabel = value;
  }

  // Path("congestioncontrol")
  [XmlRoot("results")]
  public class CongestionControlList : BaseApiListBean<CongestionControl> {    public override List<CongestionControl>? GetItems() => items;

    public override void SetItems(List<CongestionControl>? value) => items = value;

  }
}

}