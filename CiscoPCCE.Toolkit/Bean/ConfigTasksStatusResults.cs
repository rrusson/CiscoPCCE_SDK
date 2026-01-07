using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class ConfigTasksStatusResults : BaseApiBean {
  
  [XmlElement("state")]
  public StateEnum State { get; set; }

}

}