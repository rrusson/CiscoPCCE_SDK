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


@XmlRootElement(name="smartLicenseStatus")
public class SmartLicenseStatus extends BaseApiBean {
  private String agentEnabled;
  private String serialNumber;
  private String state;

  public String getAgentEnabled() {
     return this.agentEnabled;
  }

  public void setAgentEnabled(String agentEnabled) {
     this.agentEnabled = agentEnabled;
  }

  public String getSerialNumber() {
     return this.serialNumber;
  }

  public void setSerialNumber(String serialNumber) {
     this.serialNumber = serialNumber;
  }

  public String getState() {
     return this.state;
  }

  public void setState(String state) {
     this.state = state;
  }


}
