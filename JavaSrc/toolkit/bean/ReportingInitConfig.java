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


@XmlRootElement(name="reportingConfig")
public class ReportingInitConfig extends BaseApiBean {
  private String deviceId;
  private String hostName;
  private String ipAddress;

  public String getDeviceId() {
     return this.deviceId;
  }

  public void setDeviceId(String deviceId) {
     this.deviceId = deviceId;
  }

  public String getHostName() {
     return this.hostName;
  }

  public void setHostName(String hostName) {
     this.hostName = hostName;
  }

  public String getIpAddress() {
     return this.ipAddress;
  }

  public void setIpAddress(String ipAddress) {
     this.ipAddress = ipAddress;
  }


}
