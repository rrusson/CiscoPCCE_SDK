using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("vmStatus")]
public class VMData : BaseApiBean {
  private List<VMDatastoreData>? actualDatastores;
  private int? cores;
  private long? cpuReservation;
  private List<long?>? diskSizesInGB;
  private VMDatastore expectedDatastore;
  private string? guestOS;
  private string? hostName;
  private string? instanceId;
  private int? memoryInMB;
  private int? memoryReservation;
  private int? numberOfAddresses;
  private string? os;
  private bool? poweredOn;
  private VMProfile profile;
  private string? profileName;
  private int? videoMemory;
  private List<VMAddress>? vmAddresses;
  private string? vmAnnotation;
  private string? vmName;
  private string? vmToolsVersion;
  private bool? vmwareToolsUpToDate;

  public List<VMDatastoreData>? ActualDatastores
  {
      get => actualDatastores;
      set => actualDatastores = value;
  }


  public void setActualDatastores(List<VMDatastoreData> actualDatastores) {
     this.actualDatastores = actualDatastores;
  }

  public int? Cores
  {
      get => cores;
      set => cores = value;
  }


  public void setCores(int? cores) {
     this.cores = cores;
  }

  public long? CpuReservation
  {
      get => cpuReservation;
      set => cpuReservation = value;
  }


  public void setCpuReservation(long? cpuReservation) {
     this.cpuReservation = cpuReservation;
  }

  [XmlElement("disks")]
  [XmlElement("disk")]
  public List<long?>? DiskSizesInGB
  {
      get => diskSizesInGB;
      set => diskSizesInGB = value;
  }


  public void setDiskSizesInGB(List<long?> diskSizesInGB) {
     this.diskSizesInGB = diskSizesInGB;
  }

  public VMDatastore ExpectedDatastore
  {
      get => expectedDatastore;
      set => expectedDatastore = value;
  }


  public void setExpectedDatastore(VMDatastore expectedDatastore) {
     this.expectedDatastore = expectedDatastore;
  }

  public string? GuestOS
  {
      get => guestOS;
      set => guestOS = value;
  }


  public void setGuestOS(String guestOS) {
     this.guestOS = guestOS;
  }

  public string? HostName
  {
      get => hostName;
      set => hostName = value;
  }


  public void setHostName(String hostName) {
     this.hostName = hostName;
  }

  public string? InstanceId
  {
      get => instanceId;
      set => instanceId = value;
  }


  public void setInstanceId(String instanceId) {
     this.instanceId = instanceId;
  }

  public int? MemoryInMB
  {
      get => memoryInMB;
      set => memoryInMB = value;
  }


  public void setMemoryInMB(int? memoryInMB) {
     this.memoryInMB = memoryInMB;
  }

  public int? MemoryReservation
  {
      get => memoryReservation;
      set => memoryReservation = value;
  }


  public void setMemoryReservation(int? memoryReservation) {
     this.memoryReservation = memoryReservation;
  }

  public int? NumberOfAddresses
  {
      get => numberOfAddresses;
      set => numberOfAddresses = value;
  }


  public void setNumberOfAddresses(int? numberOfAddresses) {
     this.numberOfAddresses = numberOfAddresses;
  }

  public string? Os
  {
      get => os;
      set => os = value;
  }


  public void setOs(String os) {
     this.os = os;
  }

  public bool? PoweredOn
  {
      get => poweredOn;
      set => poweredOn = value;
  }


  public void setPoweredOn(Boolean poweredOn) {
     this.poweredOn = poweredOn;
  }

  public VMProfile Profile
  {
      get => profile;
      set => profile = value;
  }


  public void setProfile(VMProfile profile) {
     this.profile = profile;
  }

  public string? ProfileName
  {
      get => profileName;
      set => profileName = value;
  }


  public void setProfileName(String profileName) {
     this.profileName = profileName;
  }

  public int? VideoMemory
  {
      get => videoMemory;
      set => videoMemory = value;
  }


  public void setVideoMemory(int? videoMemory) {
     this.videoMemory = videoMemory;
  }

  [XmlElement("addresses")]
  [XmlElement("address")]
  public List<VMAddress>? VmAddresses
  {
      get => vmAddresses;
      set => vmAddresses = value;
  }


  public void setVmAddresses(List<VMAddress> vmAddresses) {
     this.vmAddresses = vmAddresses;
  }

  public string? VmAnnotation
  {
      get => vmAnnotation;
      set => vmAnnotation = value;
  }


  public void setVmAnnotation(String vmAnnotation) {
     this.vmAnnotation = vmAnnotation;
  }

  public string? VmName
  {
      get => vmName;
      set => vmName = value;
  }


  public void setVmName(String vmName) {
     this.vmName = vmName;
  }

  public string? VmToolsVersion
  {
      get => vmToolsVersion;
      set => vmToolsVersion = value;
  }


  public void setVmToolsVersion(String vmToolsVersion) {
     this.vmToolsVersion = vmToolsVersion;
  }

  public bool? VmwareToolsUpToDate
  {
      get => vmwareToolsUpToDate;
      set => vmwareToolsUpToDate = value;
  }


  public void setVmwareToolsUpToDate(bool? vmwareToolsUpToDate) {
     this.vmwareToolsUpToDate = vmwareToolsUpToDate;
  }


}

}