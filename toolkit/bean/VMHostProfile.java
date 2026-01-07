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


public class VMHostProfile extends BaseApiBean {
  private String biosVersion;
  private String cpuFamily;
  private List<VMDatastore> datastores;
  private String hardwareLayoutType;
  private short maxCpuOverSubscription;
  private short maxCpuReservation;
  private short maxMemoryReservation;
  private double maxStorageUsagePerDatastore;
  private short minCpuCores;
  private double minCpuSpeed;
  private long minimumMemoryMB;
  private List<String> supportedServerVersions;
  private String vendor;
  private List<VMProfile> vmsToMatch;

  public String getBiosVersion() {
     return this.biosVersion;
  }

  public void setBiosVersion(String biosVersion) {
     this.biosVersion = biosVersion;
  }

  public String getCpuFamily() {
     return this.cpuFamily;
  }

  public void setCpuFamily(String cpuFamily) {
     this.cpuFamily = cpuFamily;
  }

  @XmlElementWrapper(name="dataStores")
  @XmlElement(name="dataStore")
  public List<VMDatastore> getDatastores() {
     return this.datastores;
  }

  public void setDatastores(List<VMDatastore> datastores) {
     this.datastores = datastores;
  }

  public String getHardwareLayoutType() {
     return this.hardwareLayoutType;
  }

  public void setHardwareLayoutType(String hardwareLayoutType) {
     this.hardwareLayoutType = hardwareLayoutType;
  }

  public short getMaxCpuOverSubscription() {
     return this.maxCpuOverSubscription;
  }

  public void setMaxCpuOverSubscription(short maxCpuOverSubscription) {
     this.maxCpuOverSubscription = maxCpuOverSubscription;
  }

  public short getMaxCpuReservation() {
     return this.maxCpuReservation;
  }

  public void setMaxCpuReservation(short maxCpuReservation) {
     this.maxCpuReservation = maxCpuReservation;
  }

  public short getMaxMemoryReservation() {
     return this.maxMemoryReservation;
  }

  public void setMaxMemoryReservation(short maxMemoryReservation) {
     this.maxMemoryReservation = maxMemoryReservation;
  }

  public double getMaxStorageUsagePerDatastore() {
     return this.maxStorageUsagePerDatastore;
  }

  public void setMaxStorageUsagePerDatastore(double maxStorageUsagePerDatastore) {
     this.maxStorageUsagePerDatastore = maxStorageUsagePerDatastore;
  }

  public short getMinCpuCores() {
     return this.minCpuCores;
  }

  public void setMinCpuCores(short minCpuCores) {
     this.minCpuCores = minCpuCores;
  }

  public double getMinCpuSpeed() {
     return this.minCpuSpeed;
  }

  public void setMinCpuSpeed(double minCpuSpeed) {
     this.minCpuSpeed = minCpuSpeed;
  }

  public long getMinimumMemoryMB() {
     return this.minimumMemoryMB;
  }

  public void setMinimumMemoryMB(long minimumMemoryMB) {
     this.minimumMemoryMB = minimumMemoryMB;
  }

  @XmlElementWrapper(name="supportedServerVersions")
  @XmlElement(name="version")
  public List<String> getSupportedServerVersions() {
     return this.supportedServerVersions;
  }

  public void setSupportedServerVersions(List<String> supportedServerVersions) {
     this.supportedServerVersions = supportedServerVersions;
  }

  public String getVendor() {
     return this.vendor;
  }

  public void setVendor(String vendor) {
     this.vendor = vendor;
  }

  @XmlElementWrapper(name="vmsToMatch")
  @XmlElement(name="vm")
  public List<VMProfile> getVmsToMatch() {
     return this.vmsToMatch;
  }

  public void setVmsToMatch(List<VMProfile> vmsToMatch) {
     this.vmsToMatch = vmsToMatch;
  }


}
