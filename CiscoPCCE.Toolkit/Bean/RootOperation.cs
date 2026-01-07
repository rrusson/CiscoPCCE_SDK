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

  public OperationType OperationType
  {
      get => operationType;
      set => operationType = value;
  }

  [XmlElement("refURLs")]
  [XmlElement("refURL")]
  public List<string?>? RefUrls
  {
      get => refUrls;
      set => refUrls = value;
  }

  // Path("operation")
  [XmlRoot("results")]
  public class RootOperationList : BaseApiListBean<RootOperation> {    public override List<RootOperation>? GetItems() => items;

    public override void SetItems(List<RootOperation>? value) => items = value;

  }
}

}