using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class DeploymentTaskInfo : BaseApiBean {
    
  public string? Name { get; set; }

  public bool? Passing { get; set; }

}

}