using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("smartAgentStatus")]
public class SmartAgentStatus : BaseApiBean {
  private string? authorizationStatus;
  private string? complianceStatus;
  private string? daysLeftInEvaluationMode;
  private string? daysLeftInOutOfComplianceMode;
  private string? machineHost;
  private string? machineType;
  private string? registrationStatus;

  public string? AuthorizationStatus
  {
      get => authorizationStatus;
      set => authorizationStatus = value;
  }


  public void setAuthorizationStatus(String authorizationStatus) {
     this.authorizationStatus = authorizationStatus;
  }

  public string? ComplianceStatus
  {
      get => complianceStatus;
      set => complianceStatus = value;
  }


  public void setComplianceStatus(String complianceStatus) {
     this.complianceStatus = complianceStatus;
  }

  public string? DaysLeftInEvaluationMode
  {
      get => daysLeftInEvaluationMode;
      set => daysLeftInEvaluationMode = value;
  }


  public void setDaysLeftInEvaluationMode(String daysLeftInEvaluationMode) {
     this.daysLeftInEvaluationMode = daysLeftInEvaluationMode;
  }

  public string? DaysLeftInOutOfComplianceMode
  {
      get => daysLeftInOutOfComplianceMode;
      set => daysLeftInOutOfComplianceMode = value;
  }


  public void setDaysLeftInOutOfComplianceMode(String daysLeftInOutOfComplianceMode) {
     this.daysLeftInOutOfComplianceMode = daysLeftInOutOfComplianceMode;
  }

  public string? MachineHost
  {
      get => machineHost;
      set => machineHost = value;
  }


  public void setMachineHost(String machineHost) {
     this.machineHost = machineHost;
  }

  public string? MachineType
  {
      get => machineType;
      set => machineType = value;
  }


  public void setMachineType(String machineType) {
     this.machineType = machineType;
  }

  public string? RegistrationStatus
  {
      get => registrationStatus;
      set => registrationStatus = value;
  }


  public void setRegistrationStatus(String registrationStatus) {
     this.registrationStatus = registrationStatus;
  }


}

}