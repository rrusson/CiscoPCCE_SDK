using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("smartLicenseInfo")]
public class CvpSmartLicenseInfo : BaseApiBean {
  private string? authorizationExpires;
  private bool? authorizationFailed;
  private string? authorizationFailedReason;
  private int? cssmAuthorizationStatus;
  private int? cssmRegistrationStatus;
  private int? daysLeftInEvaluationMode;
  private int? daysLeftInOutOfCompliance;
  private string? evaluationExpiredTime;
  private bool? exportControlledAllow;
  private bool? inEnforcement;
  private string? lastAuthorizationAttempt;
  private string? lastRenewalAttempt;
  private string? nextAuthorizationAttempt;
  private string? nextRenewalAttempt;
  private int? outOfComplianceCount;
  private string? outOfComplianceTime;
  private int? overageDays;
  private string? overageDaysUpdatedTime;
  private string? productInstanceName;
  private string? registrationExpires;
  private bool? registrationFailed;
  private string? registrationFailedReason;
  private string? smartAccountName;
  private int? smartLicenseInfoId;
  private int? smartLicenseServerId;
  private string? virtualAccountName;

  public string? AuthorizationExpires
  {
      get => authorizationExpires;
      set => authorizationExpires = value;
  }


  public void setAuthorizationExpires(String authorizationExpires) {
     this.authorizationExpires = authorizationExpires;
  }

  public bool? AuthorizationFailed
  {
      get => authorizationFailed;
      set => authorizationFailed = value;
  }


  public void setAuthorizationFailed(Boolean authorizationFailed) {
     this.authorizationFailed = authorizationFailed;
  }

  public string? AuthorizationFailedReason
  {
      get => authorizationFailedReason;
      set => authorizationFailedReason = value;
  }


  public void setAuthorizationFailedReason(String authorizationFailedReason) {
     this.authorizationFailedReason = authorizationFailedReason;
  }

  public int? CssmAuthorizationStatus
  {
      get => cssmAuthorizationStatus;
      set => cssmAuthorizationStatus = value;
  }


  public void setCssmAuthorizationStatus(int? cssmAuthorizationStatus) {
     this.cssmAuthorizationStatus = cssmAuthorizationStatus;
  }

  public int? CssmRegistrationStatus
  {
      get => cssmRegistrationStatus;
      set => cssmRegistrationStatus = value;
  }


  public void setCssmRegistrationStatus(int? cssmRegistrationStatus) {
     this.cssmRegistrationStatus = cssmRegistrationStatus;
  }

  public int? DaysLeftInEvaluationMode
  {
      get => daysLeftInEvaluationMode;
      set => daysLeftInEvaluationMode = value;
  }


  public void setDaysLeftInEvaluationMode(int? daysLeftInEvaluationMode) {
     this.daysLeftInEvaluationMode = daysLeftInEvaluationMode;
  }

  public int? DaysLeftInOutOfCompliance
  {
      get => daysLeftInOutOfCompliance;
      set => daysLeftInOutOfCompliance = value;
  }


  public void setDaysLeftInOutOfCompliance(int? daysLeftInOutOfCompliance) {
     this.daysLeftInOutOfCompliance = daysLeftInOutOfCompliance;
  }

  public string? EvaluationExpiredTime
  {
      get => evaluationExpiredTime;
      set => evaluationExpiredTime = value;
  }


  public void setEvaluationExpiredTime(String evaluationExpiredTime) {
     this.evaluationExpiredTime = evaluationExpiredTime;
  }

  public bool? ExportControlledAllow
  {
      get => exportControlledAllow;
      set => exportControlledAllow = value;
  }


  public void setExportControlledAllow(Boolean exportControlledAllow) {
     this.exportControlledAllow = exportControlledAllow;
  }

  public bool? InEnforcement
  {
      get => inEnforcement;
      set => inEnforcement = value;
  }


  public void setInEnforcement(Boolean inEnforcement) {
     this.inEnforcement = inEnforcement;
  }

  public string? LastAuthorizationAttempt
  {
      get => lastAuthorizationAttempt;
      set => lastAuthorizationAttempt = value;
  }


  public void setLastAuthorizationAttempt(String lastAuthorizationAttempt) {
     this.lastAuthorizationAttempt = lastAuthorizationAttempt;
  }

  public string? LastRenewalAttempt
  {
      get => lastRenewalAttempt;
      set => lastRenewalAttempt = value;
  }


  public void setLastRenewalAttempt(String lastRenewalAttempt) {
     this.lastRenewalAttempt = lastRenewalAttempt;
  }

  public string? NextAuthorizationAttempt
  {
      get => nextAuthorizationAttempt;
      set => nextAuthorizationAttempt = value;
  }


  public void setNextAuthorizationAttempt(String nextAuthorizationAttempt) {
     this.nextAuthorizationAttempt = nextAuthorizationAttempt;
  }

  public string? NextRenewalAttempt
  {
      get => nextRenewalAttempt;
      set => nextRenewalAttempt = value;
  }


  public void setNextRenewalAttempt(String nextRenewalAttempt) {
     this.nextRenewalAttempt = nextRenewalAttempt;
  }

  public int? OutOfComplianceCount
  {
      get => outOfComplianceCount;
      set => outOfComplianceCount = value;
  }


  public void setOutOfComplianceCount(int? outOfComplianceCount) {
     this.outOfComplianceCount = outOfComplianceCount;
  }

  public string? OutOfComplianceTime
  {
      get => outOfComplianceTime;
      set => outOfComplianceTime = value;
  }


  public void setOutOfComplianceTime(String outOfComplianceTime) {
     this.outOfComplianceTime = outOfComplianceTime;
  }

  public int? OverageDays
  {
      get => overageDays;
      set => overageDays = value;
  }


  public void setOverageDays(int? overageDays) {
     this.overageDays = overageDays;
  }

  public string? OverageDaysUpdatedTime
  {
      get => overageDaysUpdatedTime;
      set => overageDaysUpdatedTime = value;
  }


  public void setOverageDaysUpdatedTime(String overageDaysUpdatedTime) {
     this.overageDaysUpdatedTime = overageDaysUpdatedTime;
  }

  public string? ProductInstanceName
  {
      get => productInstanceName;
      set => productInstanceName = value;
  }


  public void setProductInstanceName(String productInstanceName) {
     this.productInstanceName = productInstanceName;
  }

  public string? RegistrationExpires
  {
      get => registrationExpires;
      set => registrationExpires = value;
  }


  public void setRegistrationExpires(String registrationExpires) {
     this.registrationExpires = registrationExpires;
  }

  public bool? RegistrationFailed
  {
      get => registrationFailed;
      set => registrationFailed = value;
  }


  public void setRegistrationFailed(Boolean registrationFailed) {
     this.registrationFailed = registrationFailed;
  }

  public string? RegistrationFailedReason
  {
      get => registrationFailedReason;
      set => registrationFailedReason = value;
  }


  public void setRegistrationFailedReason(String registrationFailedReason) {
     this.registrationFailedReason = registrationFailedReason;
  }

  public string? SmartAccountName
  {
      get => smartAccountName;
      set => smartAccountName = value;
  }


  public void setSmartAccountName(String smartAccountName) {
     this.smartAccountName = smartAccountName;
  }

  public int? SmartLicenseInfoId
  {
      get => smartLicenseInfoId;
      set => smartLicenseInfoId = value;
  }


  public void setSmartLicenseInfoId(int? smartLicenseInfoId) {
     this.smartLicenseInfoId = smartLicenseInfoId;
  }

  public int? SmartLicenseServerId
  {
      get => smartLicenseServerId;
      set => smartLicenseServerId = value;
  }


  public void setSmartLicenseServerId(int? smartLicenseServerId) {
     this.smartLicenseServerId = smartLicenseServerId;
  }

  public string? VirtualAccountName
  {
      get => virtualAccountName;
      set => virtualAccountName = value;
  }


  public void setVirtualAccountName(String virtualAccountName) {
     this.virtualAccountName = virtualAccountName;
  }


}

}