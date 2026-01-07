using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("operation")
[XmlRoot("operationsResult")]
public class OperationsResult : BaseApiBean {
  private ApiErrors apiErrors;
  private ChangeSet createdObjects;
  private StatusType status;

  public ApiErrors ApiErrors
  {
      get => apiErrors;
      set => apiErrors = value;
  }

  public ChangeSet CreatedObjects
  {
      get => createdObjects;
      set => createdObjects = value;
  }

  public StatusType Status
  {
      get => status;
      set => status = value;
  }

  // Path("operation")
  [XmlRoot("results")]
  public class OperationsResultList : BaseApiListBean<OperationsResult> {    public override List<OperationsResult>? GetItems() => items;

    public override void SetItems(List<OperationsResult>? value) => items = value;

  }
}

}