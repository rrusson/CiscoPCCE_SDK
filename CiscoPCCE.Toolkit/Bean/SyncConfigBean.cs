using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("syncConfig")]
public class SyncConfigBean : BaseApiBean {
          
  public bool? Enabled { get; set; }

  public string? EndTime { get; set; }

  public int? Frequency { get; set; }

  [XmlElement("groups")]
  [XmlElement("group")]
  public List<string?>? Groups { get; set; }

  public string? StartTime { get; set; }

}

}