using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class AttributeValueWithAgent : BaseApiBean {
      
  public ReferenceBean Agent { get; set; }

  public string? AttributeValue { get; set; }

  public string? Description { get; set; }

}

}