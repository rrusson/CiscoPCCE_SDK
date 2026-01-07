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

  [XmlElement("validMachineTypes")]
  [XmlElement("type")]
  public List<MachineType>? ValidMachineTypes
  {
      get => validMachineTypes;
      set => validMachineTypes = value;
  }

  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineTypeMustBeChangedErrorDetailList : BaseApiListBean<MachineTypeMustBeChangedErrorDetail> {    public override List<MachineTypeMustBeChangedErrorDetail>? GetItems() => items;

    public override void SetItems(List<MachineTypeMustBeChangedErrorDetail>? value) => items = value;

  }
}

}