using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class DuplexedMachineErrorDetail : BaseApiBean {
  private List<MachineType>? machineTypes;
  private string? periperhalSetName;

  public List<MachineType>? MachineTypes
  {
      get => machineTypes;
      set => machineTypes = value;
  }


  public void setMachineTypes(List<MachineType> machineTypes) {
     this.machineTypes = machineTypes;
  }

  public string? PeriperhalSetName
  {
      get => periperhalSetName;
      set => periperhalSetName = value;
  }


  public void setPeriperhalSetName(String periperhalSetName) {
     this.periperhalSetName = periperhalSetName;
  }


}

}