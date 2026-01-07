using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("layoutprofile")]
public class LayoutProfile : BaseApiBean {
    
  public string? LayoutXml { get; set; }

  public string? LayoutXmlName { get; set; }

}

}