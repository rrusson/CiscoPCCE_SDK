using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class MachineListErrorDetail : BaseApiBean {
  private string? errorType;
  private Set machines;

  public string? ErrorType
  {
      get => errorType;
      set => errorType = value;
  }


  public void setErrorType(String errorType) {
     this.errorType = errorType;
  }

  [XmlElement("machines")]
  [XmlElement("machine")]
  public Set Machines
  {
      get => machines;
      set => machines = value;
  }


  public void setMachines(Set machines) {
     this.machines = machines;
  }


}

}