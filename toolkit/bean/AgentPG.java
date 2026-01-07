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


public class AgentPG extends BaseApiBean {
  private ReferenceBean cmSubSideA;
  private ReferenceBean cmSubSideB;
  private Boolean configured;
  private String finessePassword;
  private String finessePrimaryAddress;
  private String finesseUserName;
  private String mobileAgentCodec;

  public ReferenceBean getCmSubSideA() {
     return this.cmSubSideA;
  }

  public void setCmSubSideA(ReferenceBean cmSubSideA) {
     this.cmSubSideA = cmSubSideA;
  }

  public ReferenceBean getCmSubSideB() {
     return this.cmSubSideB;
  }

  public void setCmSubSideB(ReferenceBean cmSubSideB) {
     this.cmSubSideB = cmSubSideB;
  }

  @XmlElement(name="configured")
  public Boolean getConfigured() {
     return this.configured;
  }

  public void setConfigured(Boolean configured) {
     this.configured = configured;
  }

  public String getFinessePassword() {
     return this.finessePassword;
  }

  public void setFinessePassword(String finessePassword) {
     this.finessePassword = finessePassword;
  }

  public String getFinessePrimaryAddress() {
     return this.finessePrimaryAddress;
  }

  public void setFinessePrimaryAddress(String finessePrimaryAddress) {
     this.finessePrimaryAddress = finessePrimaryAddress;
  }

  public String getFinesseUserName() {
     return this.finesseUserName;
  }

  public void setFinesseUserName(String finesseUserName) {
     this.finesseUserName = finesseUserName;
  }

  public String getMobileAgentCodec() {
     return this.mobileAgentCodec;
  }

  public void setMobileAgentCodec(String mobileAgentCodec) {
     this.mobileAgentCodec = mobileAgentCodec;
  }


}
