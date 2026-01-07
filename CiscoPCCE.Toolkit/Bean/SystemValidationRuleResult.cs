using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("validationRule")]
public class SystemValidationRuleResult : BaseApiBean {
            
  [XmlElement("actual")]
  public string? Actual { get; set; }

  [XmlElement("expected")]
  public string? Expected { get; set; }

  [XmlElement("isValid")]
  public bool? IsValid { get; set; }

  [XmlElement("max")]
  public int? Max { get; set; }

  [XmlElement("min")]
  public int? Min { get; set; }

  [XmlElement("name")]
  public string? Name { get; set; }

}

}