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

  public CapacityInfo CapacityInfo
  {
      get => capacityInfo;
      set => capacityInfo = value;
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

  public HardwareLayoutType HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? InventoryConfigured
  {
      get => inventoryConfigured;
      set => inventoryConfigured = value;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  public SystemValidationStatus SystemValidationStatus
  {
      get => systemValidationStatus;
      set => systemValidationStatus = value;
  }

  public int? TargetDeploymentType
  {
      get => targetDeploymentType;
      set => targetDeploymentType = value;
  }

  [XmlElement("vmHosts")]
  [XmlElement("vmHost")]
  public List<VMHost>? VmHosts
  {
      get => vmHosts;
      set => vmHosts = value;
  }

  public string? VmLayoutType
  {
      get => vmLayoutType;
      set => vmLayoutType = value;
  }

  public string? VmValidationLogURL
  {
      get => vmValidationLogURL;
      set => vmValidationLogURL = value;
  }

  // Path("deploymenttypeinfo")
  [XmlRoot("results")]
  public class DeploymentTypeInfoList : BaseApiListBean<DeploymentTypeInfo> {    public override List<DeploymentTypeInfo>? GetItems() => items;

    public override void SetItems(List<DeploymentTypeInfo>? value) => items = value;

  }
}

}