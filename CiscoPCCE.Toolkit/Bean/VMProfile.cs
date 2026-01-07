using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class VMProfile : BaseApiBean {
  private int cores;
  private long cpuReservation;
  private List<long?>? diskSizesInGB;
  private string? machineType;
  private int memoryInMB;
  private int? memoryReservation;
  private string? name;
  private string? networkType;
  private int? numberOfAddresses;
  private string? os;
  private bool? required;
  private int? videoMemory;

  public int Cores
  {
      get => cores;
      set => cores = value;
  }


  public void setCores(int cores) {
     this.cores = cores;
  }

  public long CpuReservation
  {
      get => cpuReservation;
      set => cpuReservation = value;
  }


  public void setCpuReservation(long cpuReservation) {
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

  public string? MachineType
  {
      get => machineType;
      set => machineType = value;
  }


  public void setMachineType(String machineType) {
     this.machineType = machineType;
  }

  public int MemoryInMB
  {
      get => memoryInMB;
      set => memoryInMB = value;
  }


  public void setMemoryInMB(int memoryInMB) {
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

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? NetworkType
  {
      get => networkType;
      set => networkType = value;
  }


  public void setNetworkType(String networkType) {
     this.networkType = networkType;
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

  public bool? Required
  {
      get => required;
      set => required = value;
  }


  public void setRequired(bool? required) {
     this.required = required;
  }

  public int? VideoMemory
  {
      get => videoMemory;
      set => videoMemory = value;
  }


  public void setVideoMemory(int? videoMemory) {
     this.videoMemory = videoMemory;
  }


}

}