using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("serverStatus")]
public class VMServerData : BaseApiBean {
                                  
  public bool? BiosValid { get; set; }

  public bool? CpuFamilyValid { get; set; }

  public bool? CpuReservationValid { get; set; }

  public bool? CpuSpeedValid { get; set; }

  public bool? CpuSubscriptionValid { get; set; }

  public bool? DataStoresValid { get; set; }

  public string? Id { get; set; }

  public bool? MemoryReservationValid { get; set; }

  [XmlElement("optionalProfilesNotMatched")]
  [XmlElement("profile")]
  public List<VMData>? OptionalProfilesNotMatched { get; set; }

  public bool? PropertiesValid { get; set; }

  [XmlElement("requiredProfilesNotMatched")]
  [XmlElement("profile")]
  public List<VMData>? RequiredProfilesNotMatched { get; set; }

  public VMHost VMHost { get; set; }

  public VMHostData VMHostData { get; set; }

  public bool? VmLayoutValid { get; set; }

  [XmlElement("vmsDuplicated")]
  [XmlElement("vm")]
  public List<VMData>? VmsDuplicated { get; set; }

  [XmlElement("vmsMatched")]
  [XmlElement("vm")]
  public List<VMData>? VmsMatched { get; set; }

  [XmlElement("vmsNotMatched")]
  [XmlElement("vm")]
  public List<VMData>? VmsNotMatched { get; set; }

}

}