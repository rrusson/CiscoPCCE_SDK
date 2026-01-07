using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("errorDetail")]
public class MachineTypeMustBeChangedErrorDetail : BaseApiBean {
  private MachineType type;
  private List<MachineType>? validMachineTypes;

  public MachineType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(MachineType type) {
     this.type = type;
  }

  [XmlElement("validMachineTypes")]
  [XmlElement("type")]
  public List<MachineType>? ValidMachineTypes
  {
      get => validMachineTypes;
      set => validMachineTypes = value;
  }


  public void setValidMachineTypes(List<MachineType> validMachineTypes) {
     this.validMachineTypes = validMachineTypes;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineTypeMustBeChangedErrorDetailList : BaseApiListBean<MachineTypeMustBeChangedErrorDetail> {
    [XmlElement("errorDetails")]
    [XmlElement("errorDetail")]
   
    public override List<MachineTypeMustBeChangedErrorDetail>? GetItems() => items;

    public override void SetItems(List<MachineTypeMustBeChangedErrorDetail>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MachineTypeMustBeChangedErrorDetail>? items)
    {
        this.items = items;
    }
  }
}

}