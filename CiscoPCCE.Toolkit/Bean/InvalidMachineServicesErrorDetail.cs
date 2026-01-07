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


  public void setServicesFound(List<MachineService> servicesFound) {
     this.servicesFound = servicesFound;
  }

  [XmlElement("servicesRequired")]
  [XmlElement("service")]
  public List<MachineService>? ServicesRequired
  {
      get => servicesRequired;
      set => servicesRequired = value;
  }


  public void setServicesRequired(List<MachineService> servicesRequired) {
     this.servicesRequired = servicesRequired;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class InvalidMachineServicesErrorDetailList : BaseApiListBean<InvalidMachineServicesErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<InvalidMachineServicesErrorDetail>? GetItems() => items;

    public override void SetItems(List<InvalidMachineServicesErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<InvalidMachineServicesErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}