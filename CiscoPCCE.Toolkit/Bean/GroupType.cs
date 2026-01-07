using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("GroupType")]
public class GroupType : BaseApiBean {
  private Machines machines;
  private string? name;

  public Machines Machines
  {
      get => machines;
      set => machines = value;
  }


  public void setMachines(Machines machines) {
     this.machines = machines;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


}

}