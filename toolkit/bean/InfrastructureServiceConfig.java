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


@XmlRootElement(name="infrastructure")
public class InfrastructureServiceConfig extends BaseApiBean {
  private Integer maxLogDirectorySize;
  private Integer maxLogFileSize;
  private String syslogBackupServer;
  private String syslogBackupServerPort;
  private String syslogSecondaryBackupServer;
  private String syslogSecondaryBackupServerPort;
  private String syslogSecondaryServer;
  private String syslogSecondaryServerPort;
  private String syslogServer;
  private String syslogServerPort;

  public Integer getMaxLogDirectorySize() {
     return this.maxLogDirectorySize;
  }

  public void setMaxLogDirectorySize(Integer maxLogDirectorySize) {
     this.maxLogDirectorySize = maxLogDirectorySize;
  }

  public Integer getMaxLogFileSize() {
     return this.maxLogFileSize;
  }

  public void setMaxLogFileSize(Integer maxLogFileSize) {
     this.maxLogFileSize = maxLogFileSize;
  }

  public String getSyslogBackupServer() {
     return this.syslogBackupServer;
  }

  public void setSyslogBackupServer(String syslogBackupServer) {
     this.syslogBackupServer = syslogBackupServer;
  }

  public String getSyslogBackupServerPort() {
     return this.syslogBackupServerPort;
  }

  public void setSyslogBackupServerPort(String syslogBackupServerPort) {
     this.syslogBackupServerPort = syslogBackupServerPort;
  }

  public String getSyslogSecondaryBackupServer() {
     return this.syslogSecondaryBackupServer;
  }

  public void setSyslogSecondaryBackupServer(String syslogSecondaryBackupServer) {
     this.syslogSecondaryBackupServer = syslogSecondaryBackupServer;
  }

  public String getSyslogSecondaryBackupServerPort() {
     return this.syslogSecondaryBackupServerPort;
  }

  public void setSyslogSecondaryBackupServerPort(String syslogSecondaryBackupServerPort) {
     this.syslogSecondaryBackupServerPort = syslogSecondaryBackupServerPort;
  }

  public String getSyslogSecondaryServer() {
     return this.syslogSecondaryServer;
  }

  public void setSyslogSecondaryServer(String syslogSecondaryServer) {
     this.syslogSecondaryServer = syslogSecondaryServer;
  }

  public String getSyslogSecondaryServerPort() {
     return this.syslogSecondaryServerPort;
  }

  public void setSyslogSecondaryServerPort(String syslogSecondaryServerPort) {
     this.syslogSecondaryServerPort = syslogSecondaryServerPort;
  }

  public String getSyslogServer() {
     return this.syslogServer;
  }

  public void setSyslogServer(String syslogServer) {
     this.syslogServer = syslogServer;
  }

  public String getSyslogServerPort() {
     return this.syslogServerPort;
  }

  public void setSyslogServerPort(String syslogServerPort) {
     this.syslogServerPort = syslogServerPort;
  }


}
