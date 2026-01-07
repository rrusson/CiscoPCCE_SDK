using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("operation")
[XmlRoot("operation")]
public class RootOperation : BaseApiBean {
  private ChangeSet changeSet;
  private OperationType operationType;
  private List<string?>? refUrls;

  public ChangeSet ChangeSet
  {
      get => changeSet;
      set => changeSet = value;
  }


  public void setChangeSet(ChangeSet changeSet) {
     this.changeSet = changeSet;
  }

  public OperationType OperationType
  {
      get => operationType;
      set => operationType = value;
  }


  public void setOperationType(OperationType operationType) {
     this.operationType = operationType;
  }

  [XmlElement("refURLs")]
  [XmlElement("refURL")]
  public List<string?>? RefUrls
  {
      get => refUrls;
      set => refUrls = value;
  }


  public void setRefUrls(List<String> refUrls) {
     this.refUrls = refUrls;
  }


  // Path("operation")
  [XmlRoot("results")]
  public class RootOperationList : BaseApiListBean<RootOperation> {
    [XmlElement("operations")]
    [XmlElement("operation")]
   
    public override List<RootOperation>? GetItems() => items;

    public override void SetItems(List<RootOperation>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RootOperation>? items)
    {
        this.items = items;
    }
  }
}

}