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

  [XmlElement("networksRequired")]
  [XmlElement("network")]
  public List<MachineAddress>? NetworksRequired
  {
      get => networksRequired;
      set => networksRequired = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class InvalidMachineAddressesErrorDetailList : BaseApiListBean<InvalidMachineAddressesErrorDetail> {    public override List<InvalidMachineAddressesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidMachineAddressesErrorDetail>? value) => items = value;

  }
}

}