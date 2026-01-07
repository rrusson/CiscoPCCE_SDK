using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("serverStatus")]
public class VMServerData : BaseApiBean {
  private bool? biosValid;
  private bool? cpuFamilyValid;
  private bool? cpuReservationValid;
  private bool? cpuSpeedValid;
  private bool? cpuSubscriptionValid;
  private bool? dataStoresValid;
  private string? id;
  private bool? memoryReservationValid;
  private List<VMData>? optionalProfilesNotMatched;
  private bool? propertiesValid;
  private List<VMData>? requiredProfilesNotMatched;
  private VMHost vMHost;
  private VMHostData vMHostData;
  private bool? vmLayoutValid;
  private List<VMData>? vmsDuplicated;
  private List<VMData>? vmsMatched;
  private List<VMData>? vmsNotMatched;

  public bool? BiosValid
  {
      get => biosValid;
      set => biosValid = value;
  }


  public void setBiosValid(Boolean biosValid) {
     this.biosValid = biosValid;
  }

  public bool? CpuFamilyValid
  {
      get => cpuFamilyValid;
      set => cpuFamilyValid = value;
  }


  public void setCpuFamilyValid(Boolean cpuFamilyValid) {
     this.cpuFamilyValid = cpuFamilyValid;
  }

  public bool? CpuReservationValid
  {
      get => cpuReservationValid;
      set => cpuReservationValid = value;
  }


  public void setCpuReservationValid(Boolean cpuReservationValid) {
     this.cpuReservationValid = cpuReservationValid;
  }

  public bool? CpuSpeedValid
  {
      get => cpuSpeedValid;
      set => cpuSpeedValid = value;
  }


  public void setCpuSpeedValid(Boolean cpuSpeedValid) {
     this.cpuSpeedValid = cpuSpeedValid;
  }

  public bool? CpuSubscriptionValid
  {
      get => cpuSubscriptionValid;
      set => cpuSubscriptionValid = value;
  }


  public void setCpuSubscriptionValid(Boolean cpuSubscriptionValid) {
     this.cpuSubscriptionValid = cpuSubscriptionValid;
  }

  public bool? DataStoresValid
  {
      get => dataStoresValid;
      set => dataStoresValid = value;
  }


  public void setDataStoresValid(Boolean dataStoresValid) {
     this.dataStoresValid = dataStoresValid;
  }

  public string? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(String id) {
     this.id = id;
  }

  public bool? MemoryReservationValid
  {
      get => memoryReservationValid;
      set => memoryReservationValid = value;
  }


  public void setMemoryReservationValid(Boolean memoryReservationValid) {
     this.memoryReservationValid = memoryReservationValid;
  }

  [XmlElement("optionalProfilesNotMatched")]
  [XmlElement("profile")]
  public List<VMData>? OptionalProfilesNotMatched
  {
      get => optionalProfilesNotMatched;
      set => optionalProfilesNotMatched = value;
  }


  public void setOptionalProfilesNotMatched(List<VMData> optionalProfilesNotMatched) {
     this.optionalProfilesNotMatched = optionalProfilesNotMatched;
  }

  public bool? PropertiesValid
  {
      get => propertiesValid;
      set => propertiesValid = value;
  }


  public void setPropertiesValid(Boolean propertiesValid) {
     this.propertiesValid = propertiesValid;
  }

  [XmlElement("requiredProfilesNotMatched")]
  [XmlElement("profile")]
  public List<VMData>? RequiredProfilesNotMatched
  {
      get => requiredProfilesNotMatched;
      set => requiredProfilesNotMatched = value;
  }


  public void setRequiredProfilesNotMatched(List<VMData> requiredProfilesNotMatched) {
     this.requiredProfilesNotMatched = requiredProfilesNotMatched;
  }

  public VMHost VMHost
  {
      get => vMHost;
      set => vMHost = value;
  }


  public void setVMHost(VMHost vMHost) {
     this.vMHost = vMHost;
  }

  public VMHostData VMHostData
  {
      get => vMHostData;
      set => vMHostData = value;
  }


  public void setVMHostData(VMHostData vMHostData) {
     this.vMHostData = vMHostData;
  }

  public bool? VmLayoutValid
  {
      get => vmLayoutValid;
      set => vmLayoutValid = value;
  }


  public void setVmLayoutValid(Boolean vmLayoutValid) {
     this.vmLayoutValid = vmLayoutValid;
  }

  [XmlElement("vmsDuplicated")]
  [XmlElement("vm")]
  public List<VMData>? VmsDuplicated
  {
      get => vmsDuplicated;
      set => vmsDuplicated = value;
  }


  public void setVmsDuplicated(List<VMData> vmsDuplicated) {
     this.vmsDuplicated = vmsDuplicated;
  }

  [XmlElement("vmsMatched")]
  [XmlElement("vm")]
  public List<VMData>? VmsMatched
  {
      get => vmsMatched;
      set => vmsMatched = value;
  }


  public void setVmsMatched(List<VMData> vmsMatched) {
     this.vmsMatched = vmsMatched;
  }

  [XmlElement("vmsNotMatched")]
  [XmlElement("vm")]
  public List<VMData>? VmsNotMatched
  {
      get => vmsNotMatched;
      set => vmsNotMatched = value;
  }


  public void setVmsNotMatched(List<VMData> vmsNotMatched) {
     this.vmsNotMatched = vmsNotMatched;
  }


}

}