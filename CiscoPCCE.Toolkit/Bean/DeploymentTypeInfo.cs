using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("deploymenttypeinfo")
[XmlRoot("deploymentTypeInfo")]
public class DeploymentTypeInfo : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private CapacityInfo capacityInfo;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private int? deploymentType;
  private HardwareLayoutType hardwareLayoutType;
  private string? idFromRefUrl;
  private bool? inventoryConfigured;
  private PermissionInfo permissionInfo;
  private SystemValidationStatus systemValidationStatus;
  private int? targetDeploymentType;
  private List<VMHost>? vmHosts;
  private string? vmLayoutType;
  private string? vmValidationLogURL;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public CapacityInfo CapacityInfo
  {
      get => capacityInfo;
      set => capacityInfo = value;
  }


  public void setCapacityInfo(CapacityInfo capacityInfo) {
     this.capacityInfo = capacityInfo;
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

  public HardwareLayoutType HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }


  public void setHardwareLayoutType(HardwareLayoutType hardwareLayoutType) {
     this.hardwareLayoutType = hardwareLayoutType;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? InventoryConfigured
  {
      get => inventoryConfigured;
      set => inventoryConfigured = value;
  }


  public void setInventoryConfigured(Boolean inventoryConfigured) {
     this.inventoryConfigured = inventoryConfigured;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }

  public SystemValidationStatus SystemValidationStatus
  {
      get => systemValidationStatus;
      set => systemValidationStatus = value;
  }


  public void setSystemValidationStatus(SystemValidationStatus systemValidationStatus) {
     this.systemValidationStatus = systemValidationStatus;
  }

  public int? TargetDeploymentType
  {
      get => targetDeploymentType;
      set => targetDeploymentType = value;
  }


  public void setTargetDeploymentType(int? targetDeploymentType) {
     this.targetDeploymentType = targetDeploymentType;
  }

  [XmlElement("vmHosts")]
  [XmlElement("vmHost")]
  public List<VMHost>? VmHosts
  {
      get => vmHosts;
      set => vmHosts = value;
  }


  public void setVmHosts(List<VMHost> vmHosts) {
     this.vmHosts = vmHosts;
  }

  public string? VmLayoutType
  {
      get => vmLayoutType;
      set => vmLayoutType = value;
  }


  public void setVmLayoutType(String vmLayoutType) {
     this.vmLayoutType = vmLayoutType;
  }

  public string? VmValidationLogURL
  {
      get => vmValidationLogURL;
      set => vmValidationLogURL = value;
  }


  public void setVmValidationLogURL(String vmValidationLogURL) {
     this.vmValidationLogURL = vmValidationLogURL;
  }


  // Path("deploymenttypeinfo")
  [XmlRoot("results")]
  public class DeploymentTypeInfoList : BaseApiListBean<DeploymentTypeInfo> {
    [XmlElement("deploymentTypeInfos")]
    [XmlElement("deploymentTypeInfo")]
   
    public override List<DeploymentTypeInfo>? GetItems() => items;

    public override void SetItems(List<DeploymentTypeInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DeploymentTypeInfo>? items)
    {
        this.items = items;
    }
  }
}

}