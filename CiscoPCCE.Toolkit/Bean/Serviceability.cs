using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("serviceability")]
public class Serviceability : BaseApiBean {
  private ApiStats apiStats;
  private CapacityInfo capacityInfo;
  private DeploymentTaskStats deploymentTaskStats;
  private JvmStats jvmStats;
  private SystemInfo systemInfo;
  private SystemInfo systemInfoSummary;
  private SystemValidationStatus systemValidationStatus;
  private TaskStats taskStats;
  private UcceVersion ucceVersion;
  private VersionBase version;

  public ApiStats ApiStats
  {
      get => apiStats;
      set => apiStats = value;
  }


  public void setApiStats(ApiStats apiStats) {
     this.apiStats = apiStats;
  }

  public CapacityInfo CapacityInfo
  {
      get => capacityInfo;
      set => capacityInfo = value;
  }


  public void setCapacityInfo(CapacityInfo capacityInfo) {
     this.capacityInfo = capacityInfo;
  }

  public DeploymentTaskStats DeploymentTaskStats
  {
      get => deploymentTaskStats;
      set => deploymentTaskStats = value;
  }


  public void setDeploymentTaskStats(DeploymentTaskStats deploymentTaskStats) {
     this.deploymentTaskStats = deploymentTaskStats;
  }

  public JvmStats JvmStats
  {
      get => jvmStats;
      set => jvmStats = value;
  }


  public void setJvmStats(JvmStats jvmStats) {
     this.jvmStats = jvmStats;
  }

  public SystemInfo SystemInfo
  {
      get => systemInfo;
      set => systemInfo = value;
  }


  public void setSystemInfo(SystemInfo systemInfo) {
     this.systemInfo = systemInfo;
  }

  [XmlElement("systemInfoSummary")]
  public SystemInfo SystemInfoSummary
  {
      get => systemInfoSummary;
      set => systemInfoSummary = value;
  }


  public void setSystemInfoSummary(SystemInfo systemInfoSummary) {
     this.systemInfoSummary = systemInfoSummary;
  }

  [XmlElement("systemValidationStatus")]
  public SystemValidationStatus SystemValidationStatus
  {
      get => systemValidationStatus;
      set => systemValidationStatus = value;
  }


  public void setSystemValidationStatus(SystemValidationStatus systemValidationStatus) {
     this.systemValidationStatus = systemValidationStatus;
  }

  public TaskStats TaskStats
  {
      get => taskStats;
      set => taskStats = value;
  }


  public void setTaskStats(TaskStats taskStats) {
     this.taskStats = taskStats;
  }

  [XmlElement("ucceVersion")]
  public UcceVersion UcceVersion
  {
      get => ucceVersion;
      set => ucceVersion = value;
  }


  public void setUcceVersion(UcceVersion ucceVersion) {
     this.ucceVersion = ucceVersion;
  }

  public VersionBase Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(VersionBase version) {
     this.version = version;
  }


}

}