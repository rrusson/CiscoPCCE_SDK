using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("operation")
[XmlRoot("operations")]
public class Operations : BaseApiBean {
  private List<Operation>? operations;

  [XmlElement("operation")]
  public List<Operation>? Operations
  {
      get => operations;
      set => operations = value;
  }


  public void setOperations(List<Operation> operations) {
     this.operations = operations;
  }


  // Path("operation")
  [XmlRoot("results")]
  public class OperationsList : BaseApiListBean<Operations> {
    [XmlElement("operationss")]
    [XmlElement("operations")]
   
    public override List<Operations>? GetItems() => items;

    public override void SetItems(List<Operations>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Operations>? items)
    {
        this.items = items;
    }
  }
}

}