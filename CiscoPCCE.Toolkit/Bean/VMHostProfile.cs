using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMHostProfile : BaseApiBean {
  private string? biosVersion;
  private string? cpuFamily;
  private List<VMDatastore>? datastores;
  private string? hardwareLayoutType;
  private short maxCpuOverSubscription;
  private short maxCpuReservation;
  private short maxMemoryReservation;
  private double maxStorageUsagePerDatastore;
  private short minCpuCores;
  private double minCpuSpeed;
  private long minimumMemoryMB;
  private List<string?>? supportedServerVersions;
  private string? vendor;
  private List<VMProfile>? vmsToMatch;

  public string? BiosVersion
  {
      get => biosVersion;
      set => biosVersion = value;
  }


  public void setBiosVersion(String biosVersion) {
     this.biosVersion = biosVersion;
  }

  public string? CpuFamily
  {
      get => cpuFamily;
      set => cpuFamily = value;
  }


  public void setCpuFamily(String cpuFamily) {
     this.cpuFamily = cpuFamily;
  }

  [XmlElement("dataStores")]
  [XmlElement("dataStore")]
  public List<VMDatastore>? Datastores
  {
      get => datastores;
      set => datastores = value;
  }


  public void setDatastores(List<VMDatastore> datastores) {
     this.datastores = datastores;
  }

  public string? HardwareLayoutType
  {
      get => hardwareLayoutType;
      set => hardwareLayoutType = value;
  }


  public void setHardwareLayoutType(String hardwareLayoutType) {
     this.hardwareLayoutType = hardwareLayoutType;
  }

  public short MaxCpuOverSubscription
  {
      get => maxCpuOverSubscription;
      set => maxCpuOverSubscription = value;
  }


  public void setMaxCpuOverSubscription(short maxCpuOverSubscription) {
     this.maxCpuOverSubscription = maxCpuOverSubscription;
  }

  public short MaxCpuReservation
  {
      get => maxCpuReservation;
      set => maxCpuReservation = value;
  }


  public void setMaxCpuReservation(short maxCpuReservation) {
     this.maxCpuReservation = maxCpuReservation;
  }

  public short MaxMemoryReservation
  {
      get => maxMemoryReservation;
      set => maxMemoryReservation = value;
  }


  public void setMaxMemoryReservation(short maxMemoryReservation) {
     this.maxMemoryReservation = maxMemoryReservation;
  }

  public double MaxStorageUsagePerDatastore
  {
      get => maxStorageUsagePerDatastore;
      set => maxStorageUsagePerDatastore = value;
  }


  public void setMaxStorageUsagePerDatastore(double maxStorageUsagePerDatastore) {
     this.maxStorageUsagePerDatastore = maxStorageUsagePerDatastore;
  }

  public short MinCpuCores
  {
      get => minCpuCores;
      set => minCpuCores = value;
  }


  public void setMinCpuCores(short minCpuCores) {
     this.minCpuCores = minCpuCores;
  }

  public double MinCpuSpeed
  {
      get => minCpuSpeed;
      set => minCpuSpeed = value;
  }


  public void setMinCpuSpeed(double minCpuSpeed) {
     this.minCpuSpeed = minCpuSpeed;
  }

  public long MinimumMemoryMB
  {
      get => minimumMemoryMB;
      set => minimumMemoryMB = value;
  }


  public void setMinimumMemoryMB(long minimumMemoryMB) {
     this.minimumMemoryMB = minimumMemoryMB;
  }

  [XmlElement("supportedServerVersions")]
  [XmlElement("version")]
  public List<string?>? SupportedServerVersions
  {
      get => supportedServerVersions;
      set => supportedServerVersions = value;
  }


  public void setSupportedServerVersions(List<String> supportedServerVersions) {
     this.supportedServerVersions = supportedServerVersions;
  }

  public string? Vendor
  {
      get => vendor;
      set => vendor = value;
  }


  public void setVendor(String vendor) {
     this.vendor = vendor;
  }

  [XmlElement("vmsToMatch")]
  [XmlElement("vm")]
  public List<VMProfile>? VmsToMatch
  {
      get => vmsToMatch;
      set => vmsToMatch = value;
  }


  public void setVmsToMatch(List<VMProfile> vmsToMatch) {
     this.vmsToMatch = vmsToMatch;
  }


}

}