using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class MachineTypeNumberOutOfRangeErrorDetail : BaseApiBean {
  private int? actual;
  private List<MachineType>? machineTypes;
  private int? max;
  private int? min;
  private string? peripheralSetName;

  public int? Actual
  {
      get => actual;
      set => actual = value;
  }


  public void setActual(int? actual) {
     this.actual = actual;
  }

  public List<MachineType>? MachineTypes
  {
      get => machineTypes;
      set => machineTypes = value;
  }


  public void setMachineTypes(List<MachineType> machineTypes) {
     this.machineTypes = machineTypes;
  }

  public int? Max
  {
      get => max;
      set => max = value;
  }


  public void setMax(int? max) {
     this.max = max;
  }

  public int? Min
  {
      get => min;
      set => min = value;
  }


  public void setMin(int? min) {
     this.min = min;
  }

  public string? PeripheralSetName
  {
      get => peripheralSetName;
      set => peripheralSetName = value;
  }


  public void setPeripheralSetName(String peripheralSetName) {
     this.peripheralSetName = peripheralSetName;
  }


}

}