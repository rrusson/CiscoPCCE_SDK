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
@XmlRootElement(name="smartlicenseentitlement")
public class SmartLicenseEntitlement extends BaseApiBean {
  private String baseUrlfromRefUrl;
  private Integer changeStamp;
  private String correlationId;
  private ReferenceBean department;
  private String deploymentType;
  private String enforceMode;
  private String entitlementDescription;
  private String entitlementDisplayname;
  private String entitlementTag;
  private String entitlementVersion;
  private String idFromRefUrl;
  private Integer licenseType;
  private Integer lockUsage;
  private Integer outOfCompliance;
  private Integer outOfComplianceCount;
  private Integer peakUsage;
  private String refURL;
  private Integer smartLicenseEntitlementsTagID;

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

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public String getDeploymentType() {
     return this.deploymentType;
  }

  public void setDeploymentType(String deploymentType) {
     this.deploymentType = deploymentType;
  }

  public String getEnforceMode() {
     return this.enforceMode;
  }

  public void setEnforceMode(String enforceMode) {
     this.enforceMode = enforceMode;
  }

  public String getEntitlementDescription() {
     return this.entitlementDescription;
  }

  public void setEntitlementDescription(String entitlementDescription) {
     this.entitlementDescription = entitlementDescription;
  }

  public String getEntitlementDisplayname() {
     return this.entitlementDisplayname;
  }

  public void setEntitlementDisplayname(String entitlementDisplayname) {
     this.entitlementDisplayname = entitlementDisplayname;
  }

  public String getEntitlementTag() {
     return this.entitlementTag;
  }

  public void setEntitlementTag(String entitlementTag) {
     this.entitlementTag = entitlementTag;
  }

  public String getEntitlementVersion() {
     return this.entitlementVersion;
  }

  public void setEntitlementVersion(String entitlementVersion) {
     this.entitlementVersion = entitlementVersion;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public Integer getLicenseType() {
     return this.licenseType;
  }

  public void setLicenseType(Integer licenseType) {
     this.licenseType = licenseType;
  }

  public Integer getLockUsage() {
     return this.lockUsage;
  }

  public void setLockUsage(Integer lockUsage) {
     this.lockUsage = lockUsage;
  }

  public Integer getOutOfCompliance() {
     return this.outOfCompliance;
  }

  public void setOutOfCompliance(Integer outOfCompliance) {
     this.outOfCompliance = outOfCompliance;
  }

  public Integer getOutOfComplianceCount() {
     return this.outOfComplianceCount;
  }

  public void setOutOfComplianceCount(Integer outOfComplianceCount) {
     this.outOfComplianceCount = outOfComplianceCount;
  }

  public Integer getPeakUsage() {
     return this.peakUsage;
  }

  public void setPeakUsage(Integer peakUsage) {
     this.peakUsage = peakUsage;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Integer getSmartLicenseEntitlementsTagID() {
     return this.smartLicenseEntitlementsTagID;
  }

  public void setSmartLicenseEntitlementsTagID(Integer smartLicenseEntitlementsTagID) {
     this.smartLicenseEntitlementsTagID = smartLicenseEntitlementsTagID;
  }


  @Path("smartlicense")
  @XmlRootElement(name = "results")
  public static class SmartLicenseEntitlementList extends BaseApiListBean<SmartLicenseEntitlement> {
    @XmlElementWrapper(name = "smartlicenseentitlements")
    @XmlElement(name = "smartlicenseentitlement")
    public List<SmartLicenseEntitlement> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseEntitlement> items) {
      this.items = items;
    }
  }
}
