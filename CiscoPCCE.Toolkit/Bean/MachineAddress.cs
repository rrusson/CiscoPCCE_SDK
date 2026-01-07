using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("address")]
public class MachineAddress : BaseApiBean {
  private string? address;
  private List<MachineService>? machineServices;
  private AddressType type;

  public string? Address
  {
      get => address;
      set => address = value;
  }


  public void setAddress(String address) {
     this.address = address;
  }

  [XmlElement("services")]
  [XmlElement("service")]
  public List<MachineService>? MachineServices
  {
      get => machineServices;
      set => machineServices = value;
  }


  public void setMachineServices(List<MachineService> machineServices) {
     this.machineServices = machineServices;
  }

  public AddressType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(AddressType type) {
     this.type = type;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineAddressList : BaseApiListBean<MachineAddress> {
    [XmlElement("addresss")]
    [XmlElement("address")]
   
    public override List<MachineAddress>? GetItems() => items;

    public override void SetItems(List<MachineAddress>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MachineAddress>? items)
    {
        this.items = items;
    }
  }
}

}