using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("version")]
public class VersionInfo : BaseApiBean {
  
  [XmlElement("ucceVersion")]
  public UcceVersion UcceVersion { get; set; }

}

}