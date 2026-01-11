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
@XmlRootElement(name="smartlicenseserverinfo")
public class SmartLicenseServerInfo extends BaseApiBean {
  private String agentId;
  private String baseUrlfromRefUrl;
  private String callHomeUrl;
  private Integer changeStamp;
  private String correlationId;
  private Integer cssmResponseTimeout;
  private ReferenceBean department;
  private Integer deploymentMode;
  private Boolean excludeSpikes;
  private Boolean force;
  private String idFromRefUrl;
  private String idToken;
  private Integer licenseType;
  private Boolean outOfCompliance;
  private Integer outOfComplianceCount;
  private Date outOfComplianceStartTime;
  private String proxyHostnameOrIP;
  private Integer proxyPort;
  private String refURL;
  private String reservationStatus;
  private ReservationType reservationType;
  private String serialNumber;
  private String smartCode;
  private Integer smartLicenseServerID;
  private String smartTransportUrl;
  private String transportGatewayUrl;
  private Integer transportMode;
  private Integer transportType;
  private String transportUrl;
  private Integer usageMode;

  public String getAgentId() {
     return this.agentId;
  }

  public void setAgentId(String agentId) {
     this.agentId = agentId;
  }

  public String getBaseUrlfromRefUrl() {
     return this.baseUrlfromRefUrl;
  }

  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public String getCallHomeUrl() {
     return this.callHomeUrl;
  }

  public void setCallHomeUrl(String callHomeUrl) {
     this.callHomeUrl = callHomeUrl;
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

  public Integer getCssmResponseTimeout() {
     return this.cssmResponseTimeout;
  }

  public void setCssmResponseTimeout(Integer cssmResponseTimeout) {
     this.cssmResponseTimeout = cssmResponseTimeout;
  }

  public ReferenceBean getDepartment() {
     return this.department;
  }

  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public Integer getDeploymentMode() {
     return this.deploymentMode;
  }

  public void setDeploymentMode(Integer deploymentMode) {
     this.deploymentMode = deploymentMode;
  }

  public Boolean getExcludeSpikes() {
     return this.excludeSpikes;
  }

  public void setExcludeSpikes(Boolean excludeSpikes) {
     this.excludeSpikes = excludeSpikes;
  }

  public Boolean getForce() {
     return this.force;
  }

  public void setForce(Boolean force) {
     this.force = force;
  }

  public String getIdFromRefUrl() {
     return this.idFromRefUrl;
  }

  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public String getIdToken() {
     return this.idToken;
  }

  public void setIdToken(String idToken) {
     this.idToken = idToken;
  }

  public Integer getLicenseType() {
     return this.licenseType;
  }

  public void setLicenseType(Integer licenseType) {
     this.licenseType = licenseType;
  }

  public Boolean getOutOfCompliance() {
     return this.outOfCompliance;
  }

  public void setOutOfCompliance(Boolean outOfCompliance) {
     this.outOfCompliance = outOfCompliance;
  }

  public Integer getOutOfComplianceCount() {
     return this.outOfComplianceCount;
  }

  public void setOutOfComplianceCount(Integer outOfComplianceCount) {
     this.outOfComplianceCount = outOfComplianceCount;
  }

  public Date getOutOfComplianceStartTime() {
     return this.outOfComplianceStartTime;
  }

  public void setOutOfComplianceStartTime(Date outOfComplianceStartTime) {
     this.outOfComplianceStartTime = outOfComplianceStartTime;
  }

  public String getProxyHostnameOrIP() {
     return this.proxyHostnameOrIP;
  }

  public void setProxyHostnameOrIP(String proxyHostnameOrIP) {
     this.proxyHostnameOrIP = proxyHostnameOrIP;
  }

  public Integer getProxyPort() {
     return this.proxyPort;
  }

  public void setProxyPort(Integer proxyPort) {
     this.proxyPort = proxyPort;
  }

  public String getRefURL() {
     return this.refURL;
  }

  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public String getReservationStatus() {
     return this.reservationStatus;
  }

  public void setReservationStatus(String reservationStatus) {
     this.reservationStatus = reservationStatus;
  }

  public ReservationType getReservationType() {
     return this.reservationType;
  }

  public void setReservationType(ReservationType reservationType) {
     this.reservationType = reservationType;
  }

  public String getSerialNumber() {
     return this.serialNumber;
  }

  public void setSerialNumber(String serialNumber) {
     this.serialNumber = serialNumber;
  }

  public String getSmartCode() {
     return this.smartCode;
  }

  public void setSmartCode(String smartCode) {
     this.smartCode = smartCode;
  }

  public Integer getSmartLicenseServerID() {
     return this.smartLicenseServerID;
  }

  public void setSmartLicenseServerID(Integer smartLicenseServerID) {
     this.smartLicenseServerID = smartLicenseServerID;
  }

  public String getSmartTransportUrl() {
     return this.smartTransportUrl;
  }

  public void setSmartTransportUrl(String smartTransportUrl) {
     this.smartTransportUrl = smartTransportUrl;
  }

  public String getTransportGatewayUrl() {
     return this.transportGatewayUrl;
  }

  public void setTransportGatewayUrl(String transportGatewayUrl) {
     this.transportGatewayUrl = transportGatewayUrl;
  }

  public Integer getTransportMode() {
     return this.transportMode;
  }

  public void setTransportMode(Integer transportMode) {
     this.transportMode = transportMode;
  }

  public Integer getTransportType() {
     return this.transportType;
  }

  public void setTransportType(Integer transportType) {
     this.transportType = transportType;
  }

  public String getTransportUrl() {
     return this.transportUrl;
  }

  public void setTransportUrl(String transportUrl) {
     this.transportUrl = transportUrl;
  }

  public Integer getUsageMode() {
     return this.usageMode;
  }

  public void setUsageMode(Integer usageMode) {
     this.usageMode = usageMode;
  }


  @Path("smartlicense")
  @XmlRootElement(name = "results")
  public static class SmartLicenseServerInfoList extends BaseApiListBean<SmartLicenseServerInfo> {
    @XmlElementWrapper(name = "smartlicenseserverinfos")
    @XmlElement(name = "smartlicenseserverinfo")
    public List<SmartLicenseServerInfo> getItems() {
      return items;
    }

    public void setItems(List<SmartLicenseServerInfo> items) {
      this.items = items;
    }
  }
}
