using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("serviceability")]
public class Serviceability : BaseApiBean {
                    
  public ApiStats ApiStats { get; set; }

  public CapacityInfo CapacityInfo { get; set; }

  public DeploymentTaskStats DeploymentTaskStats { get; set; }

  public JvmStats JvmStats { get; set; }

  public SystemInfo SystemInfo { get; set; }

  [XmlElement("systemInfoSummary")]
  public SystemInfo SystemInfoSummary { get; set; }

  [XmlElement("systemValidationStatus")]
  public SystemValidationStatus SystemValidationStatus { get; set; }

  public TaskStats TaskStats { get; set; }

  [XmlElement("ucceVersion")]
  public UcceVersion UcceVersion { get; set; }

  public VersionBase Version { get; set; }

}

}