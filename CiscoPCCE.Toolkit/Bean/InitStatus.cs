using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("initStatus")]
public class InitStatus : BaseApiBean {
  private StateEnum state;
  private DeploymentModel targetDeploymentType;

  public StateEnum State
  {
      get => state;
      set => state = value;
  }


  public void setState(StateEnum state) {
     this.state = state;
  }

  public DeploymentModel TargetDeploymentType
  {
      get => targetDeploymentType;
      set => targetDeploymentType = value;
  }


  public void setTargetDeploymentType(DeploymentModel targetDeploymentType) {
     this.targetDeploymentType = targetDeploymentType;
  }


}

}