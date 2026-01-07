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

  public bool? CongestionEnabled
  {
      get => congestionEnabled;
      set => congestionEnabled = value;
  }


  public void setCongestionEnabled(Boolean congestionEnabled) {
     this.congestionEnabled = congestionEnabled;
  }

  public int? CongestionTreatmentMode
  {
      get => congestionTreatmentMode;
      set => congestionTreatmentMode = value;
  }


  public void setCongestionTreatmentMode(int? congestionTreatmentMode) {
     this.congestionTreatmentMode = congestionTreatmentMode;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public int? CpsCapacity
  {
      get => cpsCapacity;
      set => cpsCapacity = value;
  }


  public void setCpsCapacity(int? cpsCapacity) {
     this.cpsCapacity = cpsCapacity;
  }

  public int? CpsCapacityDefault
  {
      get => cpsCapacityDefault;
      set => cpsCapacityDefault = value;
  }


  public void setCpsCapacityDefault(int? cpsCapacityDefault) {
     this.cpsCapacityDefault = cpsCapacityDefault;
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

  public CongestionControlPermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(CongestionControlPermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }

  public string? SystemDefaultLabel
  {
      get => systemDefaultLabel;
      set => systemDefaultLabel = value;
  }


  public void setSystemDefaultLabel(String systemDefaultLabel) {
     this.systemDefaultLabel = systemDefaultLabel;
  }


  // Path("congestioncontrol")
  [XmlRoot("results")]
  public class CongestionControlList : BaseApiListBean<CongestionControl> {
    [XmlElement("congestionControls")]
    [XmlElement("congestionControl")]
   
    public override List<CongestionControl>? GetItems() => items;

    public override void SetItems(List<CongestionControl>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CongestionControl>? items)
    {
        this.items = items;
    }
  }
}

}