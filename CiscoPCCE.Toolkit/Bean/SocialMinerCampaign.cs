using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("Campaign")]
public class SocialMinerCampaign : BaseApiBean {
          
  public int? ChangeStamp { get; set; }

  public string? Description { get; set; }

  [XmlElement("feeds")]
  [XmlElement("feed")]
  public List<string?>? Feeds { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

}

}