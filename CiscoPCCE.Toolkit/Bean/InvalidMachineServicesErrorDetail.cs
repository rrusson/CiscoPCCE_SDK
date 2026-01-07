using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("machineinventory")
[XmlRoot("errorDetail")]
public class InvalidMachineServicesErrorDetail : BaseApiBean {
  private List<MachineService>? servicesFound;
  private List<MachineService>? servicesRequired;

  [XmlElement("servicesFound")]
  [XmlElement("service")]
  public List<MachineService>? ServicesFound
  {
      get => servicesFound;
      set => servicesFound = value;
  }

  [XmlElement("servicesRequired")]
  [XmlElement("service")]
  public List<MachineService>? ServicesRequired
  {
      get => servicesRequired;
      set => servicesRequired = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class InvalidMachineServicesErrorDetailList : BaseApiListBean<InvalidMachineServicesErrorDetail> {    public override List<InvalidMachineServicesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidMachineServicesErrorDetail>? value) => items = value;

  }
}

}