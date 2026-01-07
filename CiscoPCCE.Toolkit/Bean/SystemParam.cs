using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("systemParam")]
public class SystemParam : BaseApiBean {
    
  public Media Media { get; set; }

  public Security Security { get; set; }

}

}