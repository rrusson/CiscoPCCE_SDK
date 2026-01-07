using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class DeploymentTaskStats : BaseApiBean {
  private List<DeploymentTaskInfo>? taskStats;

  [XmlElement("deploymentTaskStats")]
  [XmlElement("deploymentTaskInfo")]
  public List<DeploymentTaskInfo>? TaskStats
  {
      get => taskStats;
      set => taskStats = value;
  }


  public void setTaskStats(List<DeploymentTaskInfo> taskStats) {
     this.taskStats = taskStats;
  }


}

}