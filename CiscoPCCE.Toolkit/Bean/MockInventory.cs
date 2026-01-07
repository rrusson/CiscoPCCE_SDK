using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("mockInventory")]
public class MockInventory : BaseApiBean {
  private bool? enableMockMode;
  private List<VMData>? vmDataList;

  public bool? EnableMockMode
  {
      get => enableMockMode;
      set => enableMockMode = value;
  }


  public void setEnableMockMode(bool? enableMockMode) {
     this.enableMockMode = enableMockMode;
  }

  [XmlElement("machines")]
  [XmlElement("machine")]
  public List<VMData>? VmDataList
  {
      get => vmDataList;
      set => vmDataList = value;
  }


  public void setVmDataList(List<VMData> vmDataList) {
     this.vmDataList = vmDataList;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MockInventoryList : BaseApiListBean<MockInventory> {
    [XmlElement("mockInventorys")]
    [XmlElement("mockInventory")]
   
    public override List<MockInventory>? GetItems() => items;

    public override void SetItems(List<MockInventory>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MockInventory>? items)
    {
        this.items = items;
    }
  }
}

}