using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class AgentDataCenterSetting : BaseApiBean {
        
  public int? AgentPhoneLineControl { get; set; }

  public string? BaseUrl { get; set; }

  public ReferenceBean DefaultDeskSetting { get; set; }

  public int? NonACDLineImpact { get; set; }

}

}