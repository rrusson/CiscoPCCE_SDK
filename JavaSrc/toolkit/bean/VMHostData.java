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


@XmlRootElement(name="vmHostData")
public class VMHostData extends BaseApiBean {
  private String bios;
  private Short cpuCores;
  private String cpuFamily;
  private Short cpuReservationPercentage;
  private double cpuSpeed;
  private Short cpuSubscriptionPercentage;
  private List<VMDatastoreData> datastores;
  private double hardDiskUsage;
  private Long memoryMB;
  private double processorFrequency;
  private short ramReservation;
  private VMHostProfile serverProfile;
  private String serverVersion;
  private long totalCapacity;
  private String vendor;

  public String getBios() {
     return this.bios;
  }

  public void setBios(String bios) {
     this.bios = bios;
  }

  public Short getCpuCores() {
     return this.cpuCores;
  }

  public void setCpuCores(Short cpuCores) {
     this.cpuCores = cpuCores;
  }

  public String getCpuFamily() {
     return this.cpuFamily;
  }

  public void setCpuFamily(String cpuFamily) {
     this.cpuFamily = cpuFamily;
  }

  public Short getCpuReservationPercentage() {
     return this.cpuReservationPercentage;
  }

  public void setCpuReservationPercentage(Short cpuReservationPercentage) {
     this.cpuReservationPercentage = cpuReservationPercentage;
  }

  public double getCpuSpeed() {
     return this.cpuSpeed;
  }

  public void setCpuSpeed(double cpuSpeed) {
     this.cpuSpeed = cpuSpeed;
  }

  public Short getCpuSubscriptionPercentage() {
     return this.cpuSubscriptionPercentage;
  }

  public void setCpuSubscriptionPercentage(Short cpuSubscriptionPercentage) {
     this.cpuSubscriptionPercentage = cpuSubscriptionPercentage;
  }

  @XmlElementWrapper(name="dataStores")
  @XmlElement(name="dataStore")
  public List<VMDatastoreData> getDatastores() {
     return this.datastores;
  }

  public void setDatastores(List<VMDatastoreData> datastores) {
     this.datastores = datastores;
  }

  public double getHardDiskUsage() {
     return this.hardDiskUsage;
  }

  public void setHardDiskUsage(double hardDiskUsage) {
     this.hardDiskUsage = hardDiskUsage;
  }

  public Long getMemoryMB() {
     return this.memoryMB;
  }

  public void setMemoryMB(Long memoryMB) {
     this.memoryMB = memoryMB;
  }

  public double getProcessorFrequency() {
     return this.processorFrequency;
  }

  public void setProcessorFrequency(double processorFrequency) {
     this.processorFrequency = processorFrequency;
  }

  public short getRamReservation() {
     return this.ramReservation;
  }

  public void setRamReservation(short ramReservation) {
     this.ramReservation = ramReservation;
  }

  @XmlElement(name="serverProfile")
  public VMHostProfile getServerProfile() {
     return this.serverProfile;
  }

  public void setServerProfile(VMHostProfile serverProfile) {
     this.serverProfile = serverProfile;
  }

  @XmlElement(name="version")
  public String getServerVersion() {
     return this.serverVersion;
  }

  public void setServerVersion(String serverVersion) {
     this.serverVersion = serverVersion;
  }

  public long getTotalCapacity() {
     return this.totalCapacity;
  }

  public void setTotalCapacity(long totalCapacity) {
     this.totalCapacity = totalCapacity;
  }

  public String getVendor() {
     return this.vendor;
  }

  public void setVendor(String vendor) {
     this.vendor = vendor;
  }


}
