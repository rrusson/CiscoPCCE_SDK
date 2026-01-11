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


@XmlRootElement(name="smartAgentStatus")
public class SmartAgentStatus extends BaseApiBean {
  private String authorizationStatus;
  private String complianceStatus;
  private String daysLeftInEvaluationMode;
  private String daysLeftInOutOfComplianceMode;
  private String machineHost;
  private String machineType;
  private String registrationStatus;

  public String getAuthorizationStatus() {
     return this.authorizationStatus;
  }

  public void setAuthorizationStatus(String authorizationStatus) {
     this.authorizationStatus = authorizationStatus;
  }

  public String getComplianceStatus() {
     return this.complianceStatus;
  }

  public void setComplianceStatus(String complianceStatus) {
     this.complianceStatus = complianceStatus;
  }

  public String getDaysLeftInEvaluationMode() {
     return this.daysLeftInEvaluationMode;
  }

  public void setDaysLeftInEvaluationMode(String daysLeftInEvaluationMode) {
     this.daysLeftInEvaluationMode = daysLeftInEvaluationMode;
  }

  public String getDaysLeftInOutOfComplianceMode() {
     return this.daysLeftInOutOfComplianceMode;
  }

  public void setDaysLeftInOutOfComplianceMode(String daysLeftInOutOfComplianceMode) {
     this.daysLeftInOutOfComplianceMode = daysLeftInOutOfComplianceMode;
  }

  public String getMachineHost() {
     return this.machineHost;
  }

  public void setMachineHost(String machineHost) {
     this.machineHost = machineHost;
  }

  public String getMachineType() {
     return this.machineType;
  }

  public void setMachineType(String machineType) {
     this.machineType = machineType;
  }

  public String getRegistrationStatus() {
     return this.registrationStatus;
  }

  public void setRegistrationStatus(String registrationStatus) {
     this.registrationStatus = registrationStatus;
  }


}
