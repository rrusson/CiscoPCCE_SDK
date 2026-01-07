using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class MachineErrorDetail : BaseApiBean {
  private string? machineName;
  private MachineType machineType;
  private string? side;

  public string? MachineName
  {
      get => machineName;
      set => machineName = value;
  }


  public void setMachineName(String machineName) {
     this.machineName = machineName;
  }

  public MachineType MachineType
  {
      get => machineType;
      set => machineType = value;
  }


  public void setMachineType(MachineType machineType) {
     this.machineType = machineType;
  }

  public string? Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(String side) {
     this.side = side;
  }


}

}