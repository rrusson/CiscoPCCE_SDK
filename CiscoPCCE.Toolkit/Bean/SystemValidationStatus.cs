using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("systemValidationStatus")]
public class SystemValidationStatus : BaseApiBean {
  private bool? isValid;
  private List<SystemValidationRuleResult>? systemValidationResult;
  private VMValidationResult vmValidationResult;

  [XmlElement("isValid")]
  public bool? IsValid
  {
      get => isValid;
      set => isValid = value;
  }


  public void setIsValid(Boolean isValid) {
     this.isValid = isValid;
  }

  [XmlElement("validationRules")]
  [XmlElement("validationRule")]
  public List<SystemValidationRuleResult>? SystemValidationResult
  {
      get => systemValidationResult;
      set => systemValidationResult = value;
  }


  public void setSystemValidationResult(List<SystemValidationRuleResult> systemValidationResult) {
     this.systemValidationResult = systemValidationResult;
  }

  [XmlElement("vmValidationResult")]
  public VMValidationResult VmValidationResult
  {
      get => vmValidationResult;
      set => vmValidationResult = value;
  }


  public void setVmValidationResult(VMValidationResult vmValidationResult) {
     this.vmValidationResult = vmValidationResult;
  }


}

}