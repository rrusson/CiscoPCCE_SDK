using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class AttributeValueWithAttribute : BaseApiBean {
      
  public ReferenceBean Attribute { get; set; }

  public string? AttributeValue { get; set; }

  public string? Description { get; set; }

}

}