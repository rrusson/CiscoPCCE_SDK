using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vmHostData")]
public class VMHostData : BaseApiBean {
  private string? bios;
  private Short cpuCores;
  private string? cpuFamily;
  private Short cpuReservationPercentage;
  private double cpuSpeed;
  private Short cpuSubscriptionPercentage;
  private List<VMDatastoreData>? datastores;
  private double hardDiskUsage;
  private long? memoryMB;
  private double processorFrequency;
  private short ramReservation;
  private VMHostProfile serverProfile;
  private string? serverVersion;
  private long totalCapacity;
  private string? vendor;

  public string? Bios
  {
      get => bios;
      set => bios = value;
  }


  public void setBios(String bios) {
     this.bios = bios;
  }

  public Short CpuCores
  {
      get => cpuCores;
      set => cpuCores = value;
  }


  public void setCpuCores(Short cpuCores) {
     this.cpuCores = cpuCores;
  }

  public string? CpuFamily
  {
      get => cpuFamily;
      set => cpuFamily = value;
  }


  public void setCpuFamily(String cpuFamily) {
     this.cpuFamily = cpuFamily;
  }

  public Short CpuReservationPercentage
  {
      get => cpuReservationPercentage;
      set => cpuReservationPercentage = value;
  }


  public void setCpuReservationPercentage(Short cpuReservationPercentage) {
     this.cpuReservationPercentage = cpuReservationPercentage;
  }

  public double CpuSpeed
  {
      get => cpuSpeed;
      set => cpuSpeed = value;
  }


  public void setCpuSpeed(double cpuSpeed) {
     this.cpuSpeed = cpuSpeed;
  }

  public Short CpuSubscriptionPercentage
  {
      get => cpuSubscriptionPercentage;
      set => cpuSubscriptionPercentage = value;
  }


  public void setCpuSubscriptionPercentage(Short cpuSubscriptionPercentage) {
     this.cpuSubscriptionPercentage = cpuSubscriptionPercentage;
  }

  [XmlElement("dataStores")]
  [XmlElement("dataStore")]
  public List<VMDatastoreData>? Datastores
  {
      get => datastores;
      set => datastores = value;
  }


  public void setDatastores(List<VMDatastoreData> datastores) {
     this.datastores = datastores;
  }

  public double HardDiskUsage
  {
      get => hardDiskUsage;
      set => hardDiskUsage = value;
  }


  public void setHardDiskUsage(double hardDiskUsage) {
     this.hardDiskUsage = hardDiskUsage;
  }

  public long? MemoryMB
  {
      get => memoryMB;
      set => memoryMB = value;
  }


  public void setMemoryMB(long? memoryMB) {
     this.memoryMB = memoryMB;
  }

  public double ProcessorFrequency
  {
      get => processorFrequency;
      set => processorFrequency = value;
  }


  public void setProcessorFrequency(double processorFrequency) {
     this.processorFrequency = processorFrequency;
  }

  public short RamReservation
  {
      get => ramReservation;
      set => ramReservation = value;
  }


  public void setRamReservation(short ramReservation) {
     this.ramReservation = ramReservation;
  }

  [XmlElement("serverProfile")]
  public VMHostProfile ServerProfile
  {
      get => serverProfile;
      set => serverProfile = value;
  }


  public void setServerProfile(VMHostProfile serverProfile) {
     this.serverProfile = serverProfile;
  }

  [XmlElement("version")]
  public string? ServerVersion
  {
      get => serverVersion;
      set => serverVersion = value;
  }


  public void setServerVersion(String serverVersion) {
     this.serverVersion = serverVersion;
  }

  public long TotalCapacity
  {
      get => totalCapacity;
      set => totalCapacity = value;
  }


  public void setTotalCapacity(long totalCapacity) {
     this.totalCapacity = totalCapacity;
  }

  public string? Vendor
  {
      get => vendor;
      set => vendor = value;
  }


  public void setVendor(String vendor) {
     this.vendor = vendor;
  }


}

}