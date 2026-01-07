using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("WrapUpReason")]
public class WrapUpReasonsConfig : BaseApiBean {
      
  public string? ForAll { get; set; }

  public string? Label { get; set; }

  public string? Uri { get; set; }

}

}