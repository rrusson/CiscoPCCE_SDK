using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("errorDetail")]
public class InvalidMachineAddressesErrorDetail : BaseApiBean {
  private List<MachineAddress>? networksFound;
  private List<MachineAddress>? networksRequired;

  [XmlElement("networksFound")]
  [XmlElement("network")]
  public List<MachineAddress>? NetworksFound
  {
      get => networksFound;
      set => networksFound = value;
  }


  public void setNetworksFound(List<MachineAddress> networksFound) {
     this.networksFound = networksFound;
  }

  [XmlElement("networksRequired")]
  [XmlElement("network")]
  public List<MachineAddress>? NetworksRequired
  {
      get => networksRequired;
      set => networksRequired = value;
  }


  public void setNetworksRequired(List<MachineAddress> networksRequired) {
     this.networksRequired = networksRequired;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class InvalidMachineAddressesErrorDetailList : BaseApiListBean<InvalidMachineAddressesErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<InvalidMachineAddressesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidMachineAddressesErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InvalidMachineAddressesErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}