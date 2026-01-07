using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class DeploymentTaskStats : BaseApiBean {
  
  [XmlElement("deploymentTaskStats")]
  [XmlElement("deploymentTaskInfo")]
  public List<DeploymentTaskInfo>? TaskStats { get; set; }

}

}