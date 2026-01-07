using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("systemValidationStatus")]
public class SystemValidationStatus : BaseApiBean {
      
  [XmlElement("isValid")]
  public bool? IsValid { get; set; }

  [XmlElement("validationRules")]
  [XmlElement("validationRule")]
  public List<SystemValidationRuleResult>? SystemValidationResult { get; set; }

  [XmlElement("vmValidationResult")]
  public VMValidationResult VmValidationResult { get; set; }

}

}