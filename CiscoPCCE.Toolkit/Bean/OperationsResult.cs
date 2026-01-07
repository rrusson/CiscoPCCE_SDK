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


  public void setApiErrors(ApiErrors apiErrors) {
     this.apiErrors = apiErrors;
  }

  public ChangeSet CreatedObjects
  {
      get => createdObjects;
      set => createdObjects = value;
  }


  public void setCreatedObjects(ChangeSet createdObjects) {
     this.createdObjects = createdObjects;
  }

  public StatusType Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(StatusType status) {
     this.status = status;
  }


  // Path("operation")
  [XmlRoot("results")]
  public class OperationsResultList : BaseApiListBean<OperationsResult> {
    [XmlElement("operationsResults")]
    [XmlElement("operationsResult")]
   
    public override List<OperationsResult>? GetItems() => items;

    public override void SetItems(List<OperationsResult>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<OperationsResult>? items)
    {
        this.items = items;
    }
  }
}

}