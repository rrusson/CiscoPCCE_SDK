using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class Feature : BaseApiBean {
    
  public string? FeatureName { get; set; }

  public bool? SystemDefined { get; set; }

}

}