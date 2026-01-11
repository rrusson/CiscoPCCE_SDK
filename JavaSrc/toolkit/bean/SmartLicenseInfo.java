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


@Path("smartlicense")
@XmlRootElement(name="smartlicenseinfo")
public class SmartLicenseInfo extends BaseApiBean {
  private Date authorizationExpires;
  private String authorizationFailedReason;
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private Integer cssmAuthorizationStatus;
  private Integer cssmRegistrationStatus;
  private Integer daysLeftInEvaluationMode;
  private Integer daysLeftInOutOfCompliance;
  private ReferenceBean department;
  private Date evaluationExpiredTime;
  private Boolean exportControlledAllow;
  private Date futureUseDateTime1;
  private Integer futureUseInt6;
  private String idFromRefUrl;
  private Boolean isAuthorizationFailed;
  private Boolean isRegistrationFailed;
  private Date lastAuthorizationAttempt;
  private Date lastRenewalAttempt;
  private Date nextAuthorizationAttempt;
  private Date nextRenewalAttempt;
  private Integer overageDays;
  private Date overageDaysUpdatedTime;
  private String productDisplayName;
  private String productInstance;
  private String refURL;
  private Date registrationExpires;
  private String registrationFailedReason;
  private String smartAccount;
  private Integer smartLicenseInfoID;
  private Integer smartLicenseServerId;
  private String timeZoneName;
  private String virtualAccount;

  public Date getAuthorizationExpires() {
     return this.authorizationExpires;
  }

  public void setAuthorizationExpires(Date authorizationExpires) {
     this.authorizationExpires = authorizationExpires;
  }

  public String getAuthorizationFailedReason() {
     return this.authorizationFailedReason;
  }

  public void setAuthorizationFailedReason(String authorizationFailedReason) {
     this.authorizationFailedReason = authorizationFailedReason;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public Integer getChangeStamp() {
     return this.changeStamp;
  }

  public void setChangeStamp(Integer changeStamp) {
     this.changeStamp = changeStamp;
  }

  public String getCorrelationId() {
     return this.correlationId;
  }

  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
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

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public Date getEvaluationExpiredTime() {
     return this.evaluationExpiredTime;
  }

  public void setEvaluationExpiredTime(Date evaluationExpiredTime) {
     this.evaluationExpiredTime = evaluationExpiredTime;
  }

  public Boolean getExportControlledAllow() {
     return this.exportControlledAllow;
  }

  public void setExportControlledAllow(Boolean exportControlledAllow) {
     this.exportControlledAllow = exportControlledAllow;
  }

  public Date getFutureUseDateTime1() {
     return this.futureUseDateTime1;
  }

  public void setFutureUseDateTime1(Date futureUseDateTime1) {
     this.futureUseDateTime1 = futureUseDateTime1;
  }

  public Integer getFutureUseInt6() {
     return this.futureUseInt6;
  }

  public void setFutureUseInt6(Integer futureUseInt6) {
     this.futureUseInt6 = futureUseInt6;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Boolean getIsAuthorizationFailed() {
     return this.isAuthorizationFailed;
  }

  public void setIsAuthorizationFailed(Boolean isAuthorizationFailed) {
     this.isAuthorizationFailed = isAuthorizationFailed;
  }

  public Boolean getIsRegistrationFailed() {
     return this.isRegistrationFailed;
  }

  public void setIsRegistrationFailed(Boolean isRegistrationFailed) {
     this.isRegistrationFailed = isRegistrationFailed;
  }

  public Date getLastAuthorizationAttempt() {
     return this.lastAuthorizationAttempt;
  }

  public void setLastAuthorizationAttempt(Date lastAuthorizationAttempt) {
     this.lastAuthorizationAttempt = lastAuthorizationAttempt;
  }

  public Date getLastRenewalAttempt() {
     return this.lastRenewalAttempt;
  }

  public void setLastRenewalAttempt(Date lastRenewalAttempt) {
     this.lastRenewalAttempt = lastRenewalAttempt;
  }

  public Date getNextAuthorizationAttempt() {
     return this.nextAuthorizationAttempt;
  }

  public void setNextAuthorizationAttempt(Date nextAuthorizationAttempt) {
     this.nextAuthorizationAttempt = nextAuthorizationAttempt;
  }

  public Date getNextRenewalAttempt() {
     return this.nextRenewalAttempt;
  }

  public void setNextRenewalAttempt(Date nextRenewalAttempt) {
     this.nextRenewalAttempt = nextRenewalAttempt;
  }

  public Integer getOverageDays() {
     return this.overageDays;
  }

  public void setOverageDays(Integer overageDays) {
     this.overageDays = overageDays;
  }

  public Date getOverageDaysUpdatedTime() {
     return this.overageDaysUpdatedTime;
  }

  public void setOverageDaysUpdatedTime(Date overageDaysUpdatedTime) {
     this.overageDaysUpdatedTime = overageDaysUpdatedTime;
  }

  public String getProductDisplayName() {
     return this.productDisplayName;
  }

  public void setProductDisplayName(String productDisplayName) {
     this.productDisplayName = productDisplayName;
  }

  public String getProductInstance() {
     return this.productInstance;
  }

  public void setProductInstance(String productInstance) {
     this.productInstance = productInstance;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Date getRegistrationExpires() {
     return this.registrationExpires;
  }

  public void setRegistrationExpires(Date registrationExpires) {
     this.registrationExpires = registrationExpires;
  }

  public String getRegistrationFailedReason() {
     return this.registrationFailedReason;
  }

  public void setRegistrationFailedReason(String registrationFailedReason) {
     this.registrationFailedReason = registrationFailedReason;
  }

  public String getSmartAccount() {
     return this.smartAccount;
  }

  public void setSmartAccount(String smartAccount) {
     this.smartAccount = smartAccount;
  }

  public Integer getSmartLicenseInfoID() {
     return this.smartLicenseInfoID;
  }

  public void setSmartLicenseInfoID(Integer smartLicenseInfoID) {
     this.smartLicenseInfoID = smartLicenseInfoID;
  }

  public Integer getSmartLicenseServerId() {
     return this.smartLicenseServerId;
  }

  public void setSmartLicenseServerId(Integer smartLicenseServerId) {
     this.smartLicenseServerId = smartLicenseServerId;
  }

  public String getTimeZoneName() {
     return this.timeZoneName;
  }

  public void setTimeZoneName(String timeZoneName) {
     this.timeZoneName = timeZoneName;
  }

  public String getVirtualAccount() {
     return this.virtualAccount;
  }

  public void setVirtualAccount(String virtualAccount) {
     this.virtualAccount = virtualAccount;
  }


  @Path("smartlicense")
  @XmlRootElement(name = "results")
  public static class SmartLicenseInfoList extends BaseApiListBean<SmartLicenseInfo> {
    @XmlElementWrapper(name = "smartlicenseinfos")
    @XmlElement(name = "smartlicenseinfo")
    public List<SmartLicenseInfo> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseInfo> items) {
      this.items = items;
    }
  }
}
