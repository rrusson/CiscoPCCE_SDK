using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class DataCenterSetting : BaseApiBean {
        
  public AgentDataCenterSetting Agent { get; set; }

  public string? BaseUrl { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public NetworkLabelGlobalSetting Labels { get; set; }

}

}