using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("smartlicense")
[XmlRoot("smartlicenseinfo")]
public class SmartLicenseInfo : BaseApiBean {
  private DateTime? authorizationExpires;
  private string? authorizationFailedReason;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private int? cssmAuthorizationStatus;
  private int? cssmRegistrationStatus;
  private int? daysLeftInEvaluationMode;
  private int? daysLeftInOutOfCompliance;
  private ReferenceBean department;
  private DateTime? evaluationExpiredTime;
  private bool? exportControlledAllow;
  private DateTime? futureUseDateTime1;
  private int? futureUseInt6;
  private string? idFromRefUrl;
  private bool? isAuthorizationFailed;
  private bool? isRegistrationFailed;
  private DateTime? lastAuthorizationAttempt;
  private DateTime? lastRenewalAttempt;
  private DateTime? nextAuthorizationAttempt;
  private DateTime? nextRenewalAttempt;
  private int? overageDays;
  private DateTime? overageDaysUpdatedTime;
  private string? productDisplayName;
  private string? productInstance;
  private string? refURL;
  private DateTime? registrationExpires;
  private string? registrationFailedReason;
  private string? smartAccount;
  private int? smartLicenseInfoID;
  private int? smartLicenseServerId;
  private string? timeZoneName;
  private string? virtualAccount;

  public DateTime? AuthorizationExpires
  {
      get => authorizationExpires;
      set => authorizationExpires = value;
  }


  public void setAuthorizationExpires(Date authorizationExpires) {
     this.authorizationExpires = authorizationExpires;
  }

  public string? AuthorizationFailedReason
  {
      get => authorizationFailedReason;
      set => authorizationFailedReason = value;
  }


  public void setAuthorizationFailedReason(String authorizationFailedReason) {
     this.authorizationFailedReason = authorizationFailedReason;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
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

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public DateTime? EvaluationExpiredTime
  {
      get => evaluationExpiredTime;
      set => evaluationExpiredTime = value;
  }


  public void setEvaluationExpiredTime(Date evaluationExpiredTime) {
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

  public DateTime? FutureUseDateTime1
  {
      get => futureUseDateTime1;
      set => futureUseDateTime1 = value;
  }


  public void setFutureUseDateTime1(Date futureUseDateTime1) {
     this.futureUseDateTime1 = futureUseDateTime1;
  }

  public int? FutureUseInt6
  {
      get => futureUseInt6;
      set => futureUseInt6 = value;
  }


  public void setFutureUseInt6(int? futureUseInt6) {
     this.futureUseInt6 = futureUseInt6;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? IsAuthorizationFailed
  {
      get => isAuthorizationFailed;
      set => isAuthorizationFailed = value;
  }


  public void setIsAuthorizationFailed(Boolean isAuthorizationFailed) {
     this.isAuthorizationFailed = isAuthorizationFailed;
  }

  public bool? IsRegistrationFailed
  {
      get => isRegistrationFailed;
      set => isRegistrationFailed = value;
  }


  public void setIsRegistrationFailed(Boolean isRegistrationFailed) {
     this.isRegistrationFailed = isRegistrationFailed;
  }

  public DateTime? LastAuthorizationAttempt
  {
      get => lastAuthorizationAttempt;
      set => lastAuthorizationAttempt = value;
  }


  public void setLastAuthorizationAttempt(Date lastAuthorizationAttempt) {
     this.lastAuthorizationAttempt = lastAuthorizationAttempt;
  }

  public DateTime? LastRenewalAttempt
  {
      get => lastRenewalAttempt;
      set => lastRenewalAttempt = value;
  }


  public void setLastRenewalAttempt(Date lastRenewalAttempt) {
     this.lastRenewalAttempt = lastRenewalAttempt;
  }

  public DateTime? NextAuthorizationAttempt
  {
      get => nextAuthorizationAttempt;
      set => nextAuthorizationAttempt = value;
  }


  public void setNextAuthorizationAttempt(Date nextAuthorizationAttempt) {
     this.nextAuthorizationAttempt = nextAuthorizationAttempt;
  }

  public DateTime? NextRenewalAttempt
  {
      get => nextRenewalAttempt;
      set => nextRenewalAttempt = value;
  }


  public void setNextRenewalAttempt(Date nextRenewalAttempt) {
     this.nextRenewalAttempt = nextRenewalAttempt;
  }

  public int? OverageDays
  {
      get => overageDays;
      set => overageDays = value;
  }


  public void setOverageDays(int? overageDays) {
     this.overageDays = overageDays;
  }

  public DateTime? OverageDaysUpdatedTime
  {
      get => overageDaysUpdatedTime;
      set => overageDaysUpdatedTime = value;
  }


  public void setOverageDaysUpdatedTime(Date overageDaysUpdatedTime) {
     this.overageDaysUpdatedTime = overageDaysUpdatedTime;
  }

  public string? ProductDisplayName
  {
      get => productDisplayName;
      set => productDisplayName = value;
  }


  public void setProductDisplayName(String productDisplayName) {
     this.productDisplayName = productDisplayName;
  }

  public string? ProductInstance
  {
      get => productInstance;
      set => productInstance = value;
  }


  public void setProductInstance(String productInstance) {
     this.productInstance = productInstance;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public DateTime? RegistrationExpires
  {
      get => registrationExpires;
      set => registrationExpires = value;
  }


  public void setRegistrationExpires(Date registrationExpires) {
     this.registrationExpires = registrationExpires;
  }

  public string? RegistrationFailedReason
  {
      get => registrationFailedReason;
      set => registrationFailedReason = value;
  }


  public void setRegistrationFailedReason(String registrationFailedReason) {
     this.registrationFailedReason = registrationFailedReason;
  }

  public string? SmartAccount
  {
      get => smartAccount;
      set => smartAccount = value;
  }


  public void setSmartAccount(String smartAccount) {
     this.smartAccount = smartAccount;
  }

  public int? SmartLicenseInfoID
  {
      get => smartLicenseInfoID;
      set => smartLicenseInfoID = value;
  }


  public void setSmartLicenseInfoID(int? smartLicenseInfoID) {
     this.smartLicenseInfoID = smartLicenseInfoID;
  }

  public int? SmartLicenseServerId
  {
      get => smartLicenseServerId;
      set => smartLicenseServerId = value;
  }


  public void setSmartLicenseServerId(int? smartLicenseServerId) {
     this.smartLicenseServerId = smartLicenseServerId;
  }

  public string? TimeZoneName
  {
      get => timeZoneName;
      set => timeZoneName = value;
  }


  public void setTimeZoneName(String timeZoneName) {
     this.timeZoneName = timeZoneName;
  }

  public string? VirtualAccount
  {
      get => virtualAccount;
      set => virtualAccount = value;
  }


  public void setVirtualAccount(String virtualAccount) {
     this.virtualAccount = virtualAccount;
  }


  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseInfoList : BaseApiListBean<SmartLicenseInfo> {
    [XmlElement("smartlicenseinfos")]
    [XmlElement("smartlicenseinfo")]
   
    public override List<SmartLicenseInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseInfo>? items)
    {
        this.items = items;
    }
  }
}

}