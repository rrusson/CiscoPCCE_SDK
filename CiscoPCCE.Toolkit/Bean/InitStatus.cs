using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("initStatus")]
public class InitStatus : BaseApiBean {
    
  public StateEnum State { get; set; }

  public DeploymentModel TargetDeploymentType { get; set; }

}

}