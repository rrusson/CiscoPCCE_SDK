using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("dialedNumberCollection")]
public class DialedNumberCollection : BaseApiBean {
  
  public Collection DialedNumberConfigs { get; set; }

}

}