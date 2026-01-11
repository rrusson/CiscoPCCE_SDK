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


public class MediaServer extends BaseApiBean {
  private boolean ftpEnabled;
  private String ftpPassword;
  private Integer ftpPort;
  private String ftpUserName;
  private String hostName;
  private String ip;

  public boolean getFtpEnabled() {
     return this.ftpEnabled;
  }

  public void setFtpEnabled(boolean ftpEnabled) {
     this.ftpEnabled = ftpEnabled;
  }

  public String getFtpPassword() {
     return this.ftpPassword;
  }

  public void setFtpPassword(String ftpPassword) {
     this.ftpPassword = ftpPassword;
  }

  public Integer getFtpPort() {
     return this.ftpPort;
  }

  public void setFtpPort(Integer ftpPort) {
     this.ftpPort = ftpPort;
  }

  public String getFtpUserName() {
     return this.ftpUserName;
  }

  public void setFtpUserName(String ftpUserName) {
     this.ftpUserName = ftpUserName;
  }

  public String getHostName() {
     return this.hostName;
  }

  public void setHostName(String hostName) {
     this.hostName = hostName;
  }

  public String getIp() {
     return this.ip;
  }

  public void setIp(String ip) {
     this.ip = ip;
  }


}
