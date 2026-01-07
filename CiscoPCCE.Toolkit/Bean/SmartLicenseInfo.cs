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

  public string? AuthorizationFailedReason
  {
      get => authorizationFailedReason;
      set => authorizationFailedReason = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public int? CssmAuthorizationStatus
  {
      get => cssmAuthorizationStatus;
      set => cssmAuthorizationStatus = value;
  }

  public int? CssmRegistrationStatus
  {
      get => cssmRegistrationStatus;
      set => cssmRegistrationStatus = value;
  }

  public int? DaysLeftInEvaluationMode
  {
      get => daysLeftInEvaluationMode;
      set => daysLeftInEvaluationMode = value;
  }

  public int? DaysLeftInOutOfCompliance
  {
      get => daysLeftInOutOfCompliance;
      set => daysLeftInOutOfCompliance = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public DateTime? EvaluationExpiredTime
  {
      get => evaluationExpiredTime;
      set => evaluationExpiredTime = value;
  }

  public bool? ExportControlledAllow
  {
      get => exportControlledAllow;
      set => exportControlledAllow = value;
  }

  public DateTime? FutureUseDateTime1
  {
      get => futureUseDateTime1;
      set => futureUseDateTime1 = value;
  }

  public int? FutureUseInt6
  {
      get => futureUseInt6;
      set => futureUseInt6 = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? IsAuthorizationFailed
  {
      get => isAuthorizationFailed;
      set => isAuthorizationFailed = value;
  }

  public bool? IsRegistrationFailed
  {
      get => isRegistrationFailed;
      set => isRegistrationFailed = value;
  }

  public DateTime? LastAuthorizationAttempt
  {
      get => lastAuthorizationAttempt;
      set => lastAuthorizationAttempt = value;
  }

  public DateTime? LastRenewalAttempt
  {
      get => lastRenewalAttempt;
      set => lastRenewalAttempt = value;
  }

  public DateTime? NextAuthorizationAttempt
  {
      get => nextAuthorizationAttempt;
      set => nextAuthorizationAttempt = value;
  }

  public DateTime? NextRenewalAttempt
  {
      get => nextRenewalAttempt;
      set => nextRenewalAttempt = value;
  }

  public int? OverageDays
  {
      get => overageDays;
      set => overageDays = value;
  }

  public DateTime? OverageDaysUpdatedTime
  {
      get => overageDaysUpdatedTime;
      set => overageDaysUpdatedTime = value;
  }

  public string? ProductDisplayName
  {
      get => productDisplayName;
      set => productDisplayName = value;
  }

  public string? ProductInstance
  {
      get => productInstance;
      set => productInstance = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public DateTime? RegistrationExpires
  {
      get => registrationExpires;
      set => registrationExpires = value;
  }

  public string? RegistrationFailedReason
  {
      get => registrationFailedReason;
      set => registrationFailedReason = value;
  }

  public string? SmartAccount
  {
      get => smartAccount;
      set => smartAccount = value;
  }

  public int? SmartLicenseInfoID
  {
      get => smartLicenseInfoID;
      set => smartLicenseInfoID = value;
  }

  public int? SmartLicenseServerId
  {
      get => smartLicenseServerId;
      set => smartLicenseServerId = value;
  }

  public string? TimeZoneName
  {
      get => timeZoneName;
      set => timeZoneName = value;
  }

  public string? VirtualAccount
  {
      get => virtualAccount;
      set => virtualAccount = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseInfoList : BaseApiListBean<SmartLicenseInfo> {    public override List<SmartLicenseInfo>? GetItems() => items;

    public override void SetItems(List<SmartLicenseInfo>? value) => items = value;

  }
}

}