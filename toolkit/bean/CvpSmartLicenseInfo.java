// ----------------------------------------------
package com.cisco.ccbu.cce.unifiedconfig.toolkit.bean;

import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiBean;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.ws.rs.Path;
import javax.xml.bind.annotation.XmlRootElement;
import java.util.List;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.ReferenceBean;
import java.util.Date;
import com.cisco.ccbu.cce.unifiedconfig.toolkit.BaseApiListBean;

import javax.xml.bind.annotation.XmlElement;

import javax.xml.bind.annotation.XmlElementWrapper;


@XmlRootElement(name="smartLicenseInfo")
public class CvpSmartLicenseInfo extends BaseApiBean {
  private String authorizationExpires;
  private Boolean authorizationFailed;
  private String authorizationFailedReason;
  private Integer cssmAuthorizationStatus;
  private Integer cssmRegistrationStatus;
  private Integer daysLeftInEvaluationMode;
  private Integer daysLeftInOutOfCompliance;
  private String evaluationExpiredTime;
  private Boolean exportControlledAllow;
  private Boolean inEnforcement;
  private String lastAuthorizationAttempt;
  private String lastRenewalAttempt;
  private String nextAuthorizationAttempt;
  private String nextRenewalAttempt;
  private Integer outOfComplianceCount;
  private String outOfComplianceTime;
  private Integer overageDays;
  private String overageDaysUpdatedTime;
  private String productInstanceName;
  private String registrationExpires;
  private Boolean registrationFailed;
  private String registrationFailedReason;
  private String smartAccountName;
  private Integer smartLicenseInfoId;
  private Integer smartLicenseServerId;
  private String virtualAccountName;

  public String getAuthorizationExpires() {
     return this.authorizationExpires;
  }

  public void setAuthorizationExpires(String authorizationExpires) {
     this.authorizationExpires = authorizationExpires;
  }

  public Boolean getAuthorizationFailed() {
     return this.authorizationFailed;
  }

  public void setAuthorizationFailed(Boolean authorizationFailed) {
     this.authorizationFailed = authorizationFailed;
  }

  public String getAuthorizationFailedReason() {
     return this.authorizationFailedReason;
  }

  public void setAuthorizationFailedReason(String authorizationFailedReason) {
     this.authorizationFailedReason = authorizationFailedReason;
  }

  public Integer getCssmAuthorizationStatus() {
     return this.cssmAuthorizationStatus;
  }

  public void setCssmAuthorizationStatus(Integer cssmAuthorizationStatus) {
     this.cssmAuthorizationStatus = cssmAuthorizationStatus;
  }

  public Integer getCssmRegistrationStatus() {
     return this.cssmRegistrationStatus;
  }

  public void setCssmRegistrationStatus(Integer cssmRegistrationStatus) {
     this.cssmRegistrationStatus = cssmRegistrationStatus;
  }

  public Integer getDaysLeftInEvaluationMode() {
     return this.daysLeftInEvaluationMode;
  }

  public void setDaysLeftInEvaluationMode(Integer daysLeftInEvaluationMode) {
     this.daysLeftInEvaluationMode = daysLeftInEvaluationMode;
  }

  public Integer getDaysLeftInOutOfCompliance() {
     return this.daysLeftInOutOfCompliance;
  }

  public void setDaysLeftInOutOfCompliance(Integer daysLeftInOutOfCompliance) {
     this.daysLeftInOutOfCompliance = daysLeftInOutOfCompliance;
  }

  public String getEvaluationExpiredTime() {
     return this.evaluationExpiredTime;
  }

  public void setEvaluationExpiredTime(String evaluationExpiredTime) {
     this.evaluationExpiredTime = evaluationExpiredTime;
  }

  public Boolean getExportControlledAllow() {
     return this.exportControlledAllow;
  }

  public void setExportControlledAllow(Boolean exportControlledAllow) {
     this.exportControlledAllow = exportControlledAllow;
  }

  public Boolean getInEnforcement() {
     return this.inEnforcement;
  }

  public void setInEnforcement(Boolean inEnforcement) {
     this.inEnforcement = inEnforcement;
  }

  public String getLastAuthorizationAttempt() {
     return this.lastAuthorizationAttempt;
  }

  public void setLastAuthorizationAttempt(String lastAuthorizationAttempt) {
     this.lastAuthorizationAttempt = lastAuthorizationAttempt;
  }

  public String getLastRenewalAttempt() {
     return this.lastRenewalAttempt;
  }

  public void setLastRenewalAttempt(String lastRenewalAttempt) {
     this.lastRenewalAttempt = lastRenewalAttempt;
  }

  public String getNextAuthorizationAttempt() {
     return this.nextAuthorizationAttempt;
  }

  public void setNextAuthorizationAttempt(String nextAuthorizationAttempt) {
     this.nextAuthorizationAttempt = nextAuthorizationAttempt;
  }

  public String getNextRenewalAttempt() {
     return this.nextRenewalAttempt;
  }

  public void setNextRenewalAttempt(String nextRenewalAttempt) {
     this.nextRenewalAttempt = nextRenewalAttempt;
  }

  public Integer getOutOfComplianceCount() {
     return this.outOfComplianceCount;
  }

  public void setOutOfComplianceCount(Integer outOfComplianceCount) {
     this.outOfComplianceCount = outOfComplianceCount;
  }

  public String getOutOfComplianceTime() {
     return this.outOfComplianceTime;
  }

  public void setOutOfComplianceTime(String outOfComplianceTime) {
     this.outOfComplianceTime = outOfComplianceTime;
  }

  public Integer getOverageDays() {
     return this.overageDays;
  }

  public void setOverageDays(Integer overageDays) {
     this.overageDays = overageDays;
  }

  public String getOverageDaysUpdatedTime() {
     return this.overageDaysUpdatedTime;
  }

  public void setOverageDaysUpdatedTime(String overageDaysUpdatedTime) {
     this.overageDaysUpdatedTime = overageDaysUpdatedTime;
  }

  public String getProductInstanceName() {
     return this.productInstanceName;
  }

  public void setProductInstanceName(String productInstanceName) {
     this.productInstanceName = productInstanceName;
  }

  public String getRegistrationExpires() {
     return this.registrationExpires;
  }

  public void setRegistrationExpires(String registrationExpires) {
     this.registrationExpires = registrationExpires;
  }

  public Boolean getRegistrationFailed() {
     return this.registrationFailed;
  }

  public void setRegistrationFailed(Boolean registrationFailed) {
     this.registrationFailed = registrationFailed;
  }

  public String getRegistrationFailedReason() {
     return this.registrationFailedReason;
  }

  public void setRegistrationFailedReason(String registrationFailedReason) {
     this.registrationFailedReason = registrationFailedReason;
  }

  public String getSmartAccountName() {
     return this.smartAccountName;
  }

  public void setSmartAccountName(String smartAccountName) {
     this.smartAccountName = smartAccountName;
  }

  public Integer getSmartLicenseInfoId() {
     return this.smartLicenseInfoId;
  }

  public void setSmartLicenseInfoId(Integer smartLicenseInfoId) {
     this.smartLicenseInfoId = smartLicenseInfoId;
  }

  public Integer getSmartLicenseServerId() {
     return this.smartLicenseServerId;
  }

  public void setSmartLicenseServerId(Integer smartLicenseServerId) {
     this.smartLicenseServerId = smartLicenseServerId;
  }

  public String getVirtualAccountName() {
     return this.virtualAccountName;
  }

  public void setVirtualAccountName(String virtualAccountName) {
     this.virtualAccountName = virtualAccountName;
  }


}
